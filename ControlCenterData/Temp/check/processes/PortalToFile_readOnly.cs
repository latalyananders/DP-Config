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

public sealed partial class PortalToFile {
private IProcessContext __core_context;

public Guid CurrentProcessId => __core_context?.InstanceId??Guid.Empty;

public string LastException => __core_context?.LastException??String.Empty;

public Guid ProcessId => new Guid("db74fd06-d4ae-45fe-82c3-48d290989d81");

private Metadata.Systems InitSource { get => InitMessage.GetSource(); }

private PropertiesCollection InitProperties { get => InitMessage.Properties; }

private Metadata.DataTypes InitDataType { get => InitMessage.GetDataType(); }

private Metadata.SM InitExternalType { get => InitMessage.GetSystemDataType(); }

private void SetCurrentStep(Guid stepId)
{
     switch(stepId.ToString())
     {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. Конструктор"
             case "336a4315-b8c0-462b-9560-3bea78022a11":
                CurrentStep = new PortalToFile_336a4315b8c0462b95603bea78022a11(new Guid("336a4315-b8c0-462b-9560-3bea78022a11"));
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
    var deserialized = MsgPackSerializer.DeserializeAny2<PortalToFile>(bytes);
    __core_DataTypeFile = deserialized.__core_DataTypeFile;

    Init( deserialized.InitMessage, deserialized.InitData);
}

public override IScope Clone()
{
    var clone = new PortalToFile(__core_context, __core_metadataCache, __core_processManager, __core_dataFactory, __core_binaryProvider);
    if(DataTypeFile != null)
        clone.DataTypeFile = DataTypeFile.Clone();
    return clone;
}

protected override void SetMessage(Message message)
{
if(message.HasBody())
     DataTypeFile = message.CastToDataType<SystemModels.DataTypeFile>();

}
public void SetInternalMessage(InternalMessage value)
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "336a4315-b8c0-462b-9560-3bea78022a11" :
            SetInternalMessage_336a4315((PortalToFile_336a4315b8c0462b95603bea78022a11)CurrentStep, value);
            break;
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует SetInternalMessage");
    }
}
public InternalMessage GetMessage()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "336a4315-b8c0-462b-9560-3bea78022a11" :
            return GetMessage_336a4315((PortalToFile_336a4315b8c0462b95603bea78022a11)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetMessage");
    }
}
public Int32 GetInt()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "336a4315-b8c0-462b-9560-3bea78022a11" :
            return GetInt_336a4315((PortalToFile_336a4315b8c0462b95603bea78022a11)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetInt");
    }
}
public List<Guid> GetReceivers()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "336a4315-b8c0-462b-9560-3bea78022a11" :
            return GetReceivers_336a4315((PortalToFile_336a4315b8c0462b95603bea78022a11)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetReceivers");
    }
}
public void SetInternalMessage_336a4315(PortalToFile_336a4315b8c0462b95603bea78022a11 local, InternalMessage __core_value)
{
  local.ОтветноеСообщение = Message.CreateFromMessage(__core_value);
}

public InternalMessage GetMessage_336a4315(PortalToFile_336a4315b8c0462b95603bea78022a11 local)
{
   return ExpressionsUtils.GetMessage(DataTypeFile);
}

public int GetInt_336a4315(PortalToFile_336a4315b8c0462b95603bea78022a11 local)
{
return 30000;
}

public List<Guid> GetReceivers_336a4315(PortalToFile_336a4315b8c0462b95603bea78022a11 local)
{
   return Expressions.GetReceivers(Metadata.Systems.FileOut);
}
}

}

}

