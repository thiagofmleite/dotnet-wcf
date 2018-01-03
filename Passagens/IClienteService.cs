using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Passagens
{
    [ServiceContract]
    public interface IClienteService
    {

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "addCliente/{nome};{cpf}")]
        bool Add(string nome, string cpf);

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "getClientes/")]
        IEnumerable<Cliente> getClientes();

        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Xml, UriTemplate = "searchCliente/{nome}")]
        Cliente Buscar(string nome);

    }
}
