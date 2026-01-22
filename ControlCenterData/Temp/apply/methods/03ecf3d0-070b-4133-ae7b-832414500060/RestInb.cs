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

public class RestInb : BaseMethod  {

/// <summary>
/// 
/// </summary>
[JsonProperty]
public SystemModels.ТипДанныхФайл ТипДанныхФайл
{
get => __core_ТипДанныхФайл;
set => __core_ТипДанныхФайл = value ?? new SystemModels.ТипДанныхФайл();
}
[MessagePackMember(0)]
private SystemModels.ТипДанныхФайл __core_ТипДанныхФайл = new SystemModels.ТипДанныхФайл();



public RestInb ()
:base("RestInb")
{
}

protected override object GetHandlerDataType()
{
     return ТипДанныхФайл;
}

}


}

