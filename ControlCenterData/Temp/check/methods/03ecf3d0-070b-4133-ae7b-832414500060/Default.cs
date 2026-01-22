 using Microsoft.AspNetCore.Mvc;
                using Microsoft.AspNetCore.Authorization;
                using Microsoft.AspNetCore.Mvc.ModelBinding;
                using Asp.Versioning;
                using System;
                using System.Diagnostics;
                using System.Linq;
                using System.Text;
                using System.Collections;
                using System.Collections.Generic;
                using System.Threading.Tasks;
                
                using Adk.Net2.Protocol;
                using Newtonsoft.Json;
                using Newtonsoft.Json.Linq;
                using Newtonsoft.Json.Serialization;
                using DT;
                using DT.Utilities;
                using DT.MdmMetadata.Types;
                using DT.MdmMetadata.CoreEntity;
                using DT.MdmMetadata.BusinessProcesses;
                using DT.MdmMetadata.BusinessProcesses.Steps.Conditional;
                using DT_TypeBuilder.CodeGen;
                using DT_TypeBuilder;
                using DT.TypeBuilding;
                using DT_TypeBuilder.CodeGen.Expressions;
                using Adk.Infrastructure.Log;
                using Adk.Infrastructure;
		        using MsgPack.Serialization;
                using DT.ClusterConfiguration;
                using DT.Exceptions;
                using DT_RateLimiting;
                using System.Net;
                using System.Net.Http;
                using System.ServiceModel;
                using System.Xml.Serialization;

namespace SystemModels {

[ProducesResponseType(200)]
[ProducesResponseType(202)]
[ProducesResponseType(503)]
[ProducesResponseType(500)]
[ProducesResponseType(400)]
[ProducesResponseType(404)]
[ProducesResponseType(401)]
[ProducesResponseType(408)]
public class DefaultController : Controller {
private readonly DT.IWebModuleSerializer _serializer;

private readonly DT.IWebRequestExecutor _executor;

public DefaultController (DT.IWebModuleSerializer serializer,DT.IWebRequestExecutor executor) {_serializer = serializer;
_executor = executor;}

/// <summary>
/// RestInb
/// </summary>
[Consumes("application/json")]
[HttpPost("/RestInb")]
public async System.Threading.Tasks.Task Method_9dce2d9b
([FromBody] ТипДанныхФайл ТипДанныхФайл){

var handler = new RestInb();
handler.ТипДанныхФайл = ТипДанныхФайл;
var runMessage = handler.Execute();
var message_9dce2d9b = runMessage.CreateMessage();

var methodId = new Guid("9dce2d9b-d26a-4218-bd97-4abd626d5763");
await _executor.ExecuteNonQuery(methodId, message_9dce2d9b, HttpContext);
}

}


}

