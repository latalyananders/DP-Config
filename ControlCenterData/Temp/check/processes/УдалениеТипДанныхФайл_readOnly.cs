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

public sealed partial class УдалениеТипДанныхФайл {
private IProcessContext __core_context;

public Guid CurrentProcessId => __core_context?.InstanceId??Guid.Empty;

public string LastException => __core_context?.LastException??String.Empty;

public Guid ProcessId => new Guid("09626ac9-ac77-4dbb-82af-0af9ea37c9dc");

private Metadata.Systems InitSource { get => InitMessage.GetSource(); }

private PropertiesCollection InitProperties { get => InitMessage.Properties; }

private Metadata.DataTypes InitDataType { get => InitMessage.GetDataType(); }

private Metadata.SM InitExternalType { get => InitMessage.GetSystemDataType(); }

private void SetCurrentStep(Guid stepId)
{
     switch(stepId.ToString())
     {
#line 1 "Шаг [Удаление, Удаление]. Конструктор"
             case "33d45886-fd3d-4f0f-90f5-adf7fdd95829":
                CurrentStep = new LocalScope(new Guid("33d45886-fd3d-4f0f-90f5-adf7fdd95829"));
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
    var deserialized = MsgPackSerializer.DeserializeAny2<УдалениеТипДанныхФайл>(bytes);
    __core_ТипДанныхФайл = deserialized.__core_ТипДанныхФайл;

    Init( deserialized.InitMessage, deserialized.InitData);
}

public override IScope Clone()
{
    var clone = new УдалениеТипДанныхФайл(__core_context, __core_metadataCache, __core_processManager, __core_dataFactory, __core_binaryProvider);
    if(ТипДанныхФайл != null)
        clone.ТипДанныхФайл = ТипДанныхФайл.Clone();
    return clone;
}

public List<Entity> GetEntityList()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "33d45886-fd3d-4f0f-90f5-adf7fdd95829" :
            return GetEntityList_33d45886((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetEntityList");
    }
}
public OwnList<LinkType> GetLinkTypeOwnList()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "33d45886-fd3d-4f0f-90f5-adf7fdd95829" :
            return GetLinkTypeOwnList_33d45886((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetLinkTypeOwnList");
    }
}
public Boolean IsEntity()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "33d45886-fd3d-4f0f-90f5-adf7fdd95829" :
            return IsEntity_33d45886((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует IsEntity");
    }
}
public Boolean IsLinkType()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "33d45886-fd3d-4f0f-90f5-adf7fdd95829" :
            return IsLinkType_33d45886((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует IsLinkType");
    }
}
public List<CredentialUser> GetUsers()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "33d45886-fd3d-4f0f-90f5-adf7fdd95829" :
            return GetUsers_33d45886((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetUsers");
    }
}
}

}

}

