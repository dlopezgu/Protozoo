﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión del motor en tiempo de ejecución:2.0.50727.5456
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Protozoo.Dal.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso con establecimiento inflexible de tipos, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o vuelva a generar su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Protozoo.Dal.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso con establecimiento inflexible de tipos.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El parámetro {0} no puede nulo/vacío..
        /// </summary>
        internal static string Error_ArgumentNullException {
            get {
                return ResourceManager.GetString("Error_ArgumentNullException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error en el proceso {0}.
        /// </summary>
        internal static string Error_GenericoProcedimientoAlmacenado {
            get {
                return ResourceManager.GetString("Error_GenericoProcedimientoAlmacenado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error al convertir el valor: {0}.
        /// </summary>
        internal static string Error_InvalidCastException {
            get {
                return ResourceManager.GetString("Error_InvalidCastException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error en la base de datos: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_InvalidOperationException {
            get {
                return ResourceManager.GetString("Error_InvalidOperationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a La página solicitada es mayor que el rango permitido..
        /// </summary>
        internal static string Error_MasRegistrosDeLosDebidos {
            get {
                return ResourceManager.GetString("Error_MasRegistrosDeLosDebidos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a El valor de {0} es nulo.
        /// </summary>
        internal static string Error_NullReferenceException {
            get {
                return ResourceManager.GetString("Error_NullReferenceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error al ejecutar el procedimiento almacenado &apos;{0}&apos; en {1}. Código: &apos;{2}&apos;, Descripción: &apos;{3}&apos;..
        /// </summary>
        internal static string Error_ProcedimientoAlmacenado {
            get {
                return ResourceManager.GetString("Error_ProcedimientoAlmacenado", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Error en la base de datos: &apos;{0}&apos;.
        /// </summary>
        internal static string Error_SQLException {
            get {
                return ResourceManager.GetString("Error_SQLException", resourceCulture);
            }
        }
    }
}
