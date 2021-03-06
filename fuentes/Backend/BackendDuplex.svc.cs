﻿using System;
using System.ServiceModel;
using Protozoo.Bll.Tier2;
using Protozoo.Core;
using Protozoo.Core.Entities;

namespace Protozoo.Backend
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
   // [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Single)]
    public class BackendDuplex : IBackendDuplex
    {     
        public Entity Process(int cmd)
        {
            IBusiness domainObject = new BusinessLayer2();
            BackendDTO<Entity, Exception> serviceMessage = new BackendDTO<Entity, Exception>();
            // Captura el evento de negocio y lo incluye en el mensaje del servicio
            domainObject.SomethingIsHappening += message => 
                {
                    BackendDTO<Entity, Exception> backendResult = new BackendDTO<Entity, Exception>();
                    backendResult.Messages.Add(new Message(message + " " + DateTime.Now.ToString(), "Event"));
                    Callback.Notify(backendResult);
                };
            try
            {   // Llamada a negocio            
                serviceMessage.Data.Add(domainObject.DoSomething(cmd));
            }
            catch (Exception ex)
            {   // Se produce excepción, se incluye en el mensaje del servicio
                serviceMessage.Exceptions.Add(ex);
                throw new FaultException(ex.Message);
            }
            Callback.Notify(serviceMessage);
            return serviceMessage.Data[0];
        }

        private IBackendDuplexCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<IBackendDuplexCallback>();
            }
        }
    }
}
