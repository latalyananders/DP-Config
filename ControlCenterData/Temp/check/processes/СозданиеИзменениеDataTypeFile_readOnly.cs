using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using DT;
using DT.Exceptions;
using Metadata;
using DT.Utilities;
using DT.MdmMetadata.Types;
using DT.MdmMetadata.CoreEntity;
using DT.MdmMetadata.BusinessProcesses;
using DT.MdmMetadata.BusinessProcesses.Steps.Conditional;
using DT_TypeBuilder.CodeGen;
using DT_TypeBuilder;
using DT_TypeBuilder.Core;
using DT.TypeBuilding;
using DT_TypeBuilder.CodeGen.Expressions;
using Adk.Infrastructure.Log;
using Adk.Infrastructure;
using MsgPack.Serialization;
using DT.MdmServices;
using DT.ClusterConfiguration;
using DT_TypeBuilder.Core.Interfaces;
using DT_Processes.Services;
using DT.Metadata.Ontology;
using DT.NodeMessageProcessing.Archive;
using DT.Diagnostics.Log;
using DT.Diagnostics;
using DT.Diagnostics.Trace;
using DT.LogExtentions.OperativeLog;
using DT.Databank;
using System.Xml.Serialization;
using System.ServiceModel;

namespace SystemModels {

public static partial class SystemModel {

public sealed partial class СозданиеИзменениеDataTypeFile {
private IProcessContext __core_context;

public Guid CurrentProcessId => __core_context?.InstanceId??Guid.Empty;

public string LastException => __core_context?.LastException??String.Empty;

public Guid ProcessId => new Guid("f77268d4-47ff-4890-ba80-ad37d25fd97f");

private Metadata.Systems InitSource { get => InitMessage.GetSource(); }

private PropertiesCollection InitProperties { get => InitMessage.Properties; }

private Metadata.DataTypes InitDataType { get => InitMessage.GetDataType(); }

private Metadata.SM InitExternalType { get => InitMessage.GetSystemDataType(); }

private void SetCurrentStep(Guid stepId)
{
     switch(stepId.ToString())
     {
#line 1 "Шаг [Запись, Запись]. Конструктор"
             case "d06e01ab-3d29-40bb-936c-5065e67b6560":
                CurrentStep = new WriteEntityScope(new Guid("d06e01ab-3d29-40bb-936c-5065e67b6560"));
                break;
#line default
         default:
             throw new ArgumentException("Неизвестный шаг " + stepId);
     }
}
public override void InitFromJson(JObject jObj)
{
    BaseClassUtils.FillProperty(DataTypeFile, "DataTypeFile", jObj);
}

public override void InitFromBytes(byte[] bytes)
{
    JObject jObj = null;
    if (!bytes.IsNullOrEmpty())
    {
          var jString = (new UTF8Encoding(false)).GetString(bytes);
          jObj = JObject.Parse(jString);
    }
   DataTypeFile.InitFromJson(jObj);
}

public override JObject ToJson(bool trim = false)
{
    var jObj = base.ToJson();
  if(this.DataTypeFile != null)
      jObj["DataTypeFile"] = DataTypeFile.ToJson();
   return jObj;
}

public override void Deserialize(byte[] bytes)
{
    var deserialized = MsgPackSerializer.DeserializeAny2<СозданиеИзменениеDataTypeFile>(bytes);
    __core_DataTypeFile = deserialized.__core_DataTypeFile;

    Init( deserialized.InitMessage, deserialized.InitData);
}

public override IScope Clone()
{
    var clone = new СозданиеИзменениеDataTypeFile(__core_context, __core_metadataCache, __core_processManager, __core_dataFactory, __core_binaryProvider);
    if(DataTypeFile != null)
        clone.DataTypeFile = DataTypeFile.Clone();
    return clone;
}

protected override void SetMessage(Message message)
{
if(message.HasBody())
     DataTypeFile = message.CastToDataType<SystemModels.DataTypeFile>();

}
public void SetEntityLink((Guid, Guid) entityLink)
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Запись, Запись]. "
        case "d06e01ab-3d29-40bb-936c-5065e67b6560" :
            SetEntityLink_d06e01ab((WriteEntityScope)CurrentStep, entityLink);
            break;
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует SetEntityLink");
    }
}
public Entity GetEntity()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Запись, Запись]. "
        case "d06e01ab-3d29-40bb-936c-5065e67b6560" :
            return GetEntity_d06e01ab((WriteEntityScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetEntity");
    }
}
public CredentialUser GetUser()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Запись, Запись]. "
        case "d06e01ab-3d29-40bb-936c-5065e67b6560" :
            return GetUser_d06e01ab((WriteEntityScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetUser");
    }
}
public Boolean IsEntity()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Запись, Запись]. "
        case "d06e01ab-3d29-40bb-936c-5065e67b6560" :
            return IsEntity_d06e01ab((WriteEntityScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует IsEntity");
    }
}
}

}

}

