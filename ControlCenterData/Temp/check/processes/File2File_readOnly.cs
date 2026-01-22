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

public sealed partial class File2File {
private IProcessContext __core_context;

public Guid CurrentProcessId => __core_context?.InstanceId??Guid.Empty;

public string LastException => __core_context?.LastException??String.Empty;

public Guid ProcessId => new Guid("2447705f-aed6-4808-b429-51d22c7c92f6");

private Metadata.Systems InitSource { get => InitMessage.GetSource(); }

private PropertiesCollection InitProperties { get => InitMessage.Properties; }

private Metadata.DataTypes InitDataType { get => InitMessage.GetDataType(); }

private Metadata.SM InitExternalType { get => InitMessage.GetSystemDataType(); }

private void SetCurrentStep(Guid stepId)
{
     switch(stepId.ToString())
     {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. Конструктор"
             case "204aec04-19c6-4aba-894c-ae562250200f":
                CurrentStep = new File2File_204aec0419c64aba894cae562250200f(new Guid("204aec04-19c6-4aba-894c-ae562250200f"));
                break;
#line default
#line 1 "Шаг [Лог, Лог]. Конструктор"
             case "4c63b05e-975a-477c-91d0-f925b6d52c12":
                CurrentStep = new LocalScope(new Guid("4c63b05e-975a-477c-91d0-f925b6d52c12"));
                break;
#line default
         default:
             throw new ArgumentException("Неизвестный шаг " + stepId);
     }
}
public override void InitFromJson(JObject jObj)
{
    BaseClassUtils.FillProperty(ТипДанныхФайл, "ТипДанныхФайл", jObj);
}

public override void InitFromBytes(byte[] bytes)
{
    JObject jObj = null;
    if (!bytes.IsNullOrEmpty())
    {
          var jString = (new UTF8Encoding(false)).GetString(bytes);
          jObj = JObject.Parse(jString);
    }
   ТипДанныхФайл.InitFromJson(jObj);
}

public override JObject ToJson(bool trim = false)
{
    var jObj = base.ToJson();
  if(this.ТипДанныхФайл != null)
      jObj["ТипДанныхФайл"] = ТипДанныхФайл.ToJson();
   return jObj;
}

public override void Deserialize(byte[] bytes)
{
    var deserialized = MsgPackSerializer.DeserializeAny2<File2File>(bytes);
    __core_ТипДанныхФайл = deserialized.__core_ТипДанныхФайл;

    Init( deserialized.InitMessage, deserialized.InitData);
}

public override IScope Clone()
{
    var clone = new File2File(__core_context, __core_metadataCache, __core_processManager, __core_dataFactory, __core_binaryProvider);
    if(ТипДанныхФайл != null)
        clone.ТипДанныхФайл = ТипДанныхФайл.Clone();
    return clone;
}

protected override void SetMessage(Message message)
{
if(message.HasBody())
     ТипДанныхФайл = message.CastToDataType<SystemModels.ТипДанныхФайл>();

}
public void SetInternalMessage(InternalMessage value)
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "204aec04-19c6-4aba-894c-ae562250200f" :
            SetInternalMessage_204aec04((File2File_204aec0419c64aba894cae562250200f)CurrentStep, value);
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
        case "204aec04-19c6-4aba-894c-ae562250200f" :
            return GetMessage_204aec04((File2File_204aec0419c64aba894cae562250200f)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetMessage");
    }
}
public Int32 GetInt()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "204aec04-19c6-4aba-894c-ae562250200f" :
            return GetInt_204aec04((File2File_204aec0419c64aba894cae562250200f)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetInt");
    }
}
public List<Guid> GetReceivers()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. "
        case "204aec04-19c6-4aba-894c-ae562250200f" :
            return GetReceivers_204aec04((File2File_204aec0419c64aba894cae562250200f)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetReceivers");
    }
}
public String GetSerialized()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Лог, Лог]. "
        case "4c63b05e-975a-477c-91d0-f925b6d52c12" :
            return GetSerialized_4c63b05e((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetSerialized");
    }
}
public void SetInternalMessage_204aec04(File2File_204aec0419c64aba894cae562250200f local, InternalMessage __core_value)
{
  local.ОтветноеСообщение = Message.CreateFromMessage(__core_value);
}

public InternalMessage GetMessage_204aec04(File2File_204aec0419c64aba894cae562250200f local)
{
   return ExpressionsUtils.GetMessage(ТипДанныхФайл);
}

public int GetInt_204aec04(File2File_204aec0419c64aba894cae562250200f local)
{
return 30000;
}

public List<Guid> GetReceivers_204aec04(File2File_204aec0419c64aba894cae562250200f local)
{
   return Expressions.GetReceivers(Metadata.Systems.File2);
}
public string GetSerialized_4c63b05e(LocalScope local)
{
  return @$"Схема обработки вызвалась. Что произошло дальше? Хер его знает";
}
}

}

}

