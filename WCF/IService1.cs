using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string GetData2(int value);

        [OperationContract]
        Orden GetOrden();

        [OperationContract]
        List<string>[] GetOrden2();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }

    [DataContract]
    public class Orden
    {
        private string codCentro = "1";
        private string codRecurso = "2";
        private string codOrden = "1";
        private string codProducto = "1";
        private string producto = "ChocoSoda";
        private int cantidad = 100;
        private string tipoPal = "pal1";
        private string fecha = "28/03/2019";
        private int duracion = 3;
        private int cajxPal = 100;
        private string unidad = "kilo";
        private string umEtiqueta = "umEtiqueta";
        private string ipImpresora = "192.168.1.23";
        private string centroLote = "centroLote";
        private string recursoLote = "recurso Lote";


        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }

        [DataMember]
        public string CodCentro { get => codCentro; set => codCentro = value; }
        [DataMember]
        public string CodRecurso { get => codRecurso; set => codRecurso = value; }
        [DataMember]
        public string CodOrden { get => codOrden; set => codOrden = value; }
        [DataMember]
        public string CodProducto { get => codProducto; set => codProducto = value; }
        [DataMember]
        public string Producto { get => producto; set => producto = value; }
        [DataMember]
        public int Cantidad { get => cantidad; set => cantidad = value; }
        [DataMember]
        public string TipoPal { get => tipoPal; set => tipoPal = value; }
        [DataMember]
        public string Fecha { get => fecha; set => fecha = value; }
        [DataMember]
        public int Duracion { get => duracion; set => duracion = value; }
        [DataMember]
        public int CajxPal { get => cajxPal; set => cajxPal = value; }
        [DataMember]
        public string Unidad { get => unidad; set => unidad = value; }
        [DataMember]
        public string UmEtiqueta { get => umEtiqueta; set => umEtiqueta = value; }
        [DataMember]
        public string IpImpresora { get => ipImpresora; set => ipImpresora = value; }
        [DataMember]
        public string CentroLote { get => centroLote; set => centroLote = value; }
        [DataMember]
        public string RecursoLote { get => recursoLote; set => recursoLote = value; }
        
    }
}
