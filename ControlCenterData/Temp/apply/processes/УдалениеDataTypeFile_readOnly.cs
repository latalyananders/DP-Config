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

public sealed partial class УдалениеDataTypeFile {
private IProcessContext __core_context;

public Guid CurrentProcessId => __core_context?.InstanceId??Guid.Empty;

public string LastException => __core_context?.LastException??String.Empty;

public Guid ProcessId => new Guid("56a47819-fc30-4455-8e1a-8a2588113acd");

private Metadata.Systems InitSource { get => InitMessage.GetSource(); }

private PropertiesCollection InitProperties { get => InitMessage.Properties; }

private Metadata.DataTypes InitDataType { get => InitMessage.GetDataType(); }

private Metadata.SM InitExternalType { get => InitMessage.GetSystemDataType(); }

private void SetCurrentStep(Guid stepId)
{
     switch(stepId.ToString())
     {
#line 1 "Шаг [Удаление, Удаление]. Конструктор"
             case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9":
                CurrentStep = new LocalScope(new Guid("a5e6fa7d-0478-492f-814e-eb28bebbd3a9"));
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
    var deserialized = MsgPackSerializer.DeserializeAny2<УдалениеDataTypeFile>(bytes);
    __core_DataTypeFile = deserialized.__core_DataTypeFile;

    Init( deserialized.InitMessage, deserialized.InitData);
}

public override IScope Clone()
{
    var clone = new УдалениеDataTypeFile(__core_context, __core_metadataCache, __core_processManager, __core_dataFactory, __core_binaryProvider);
    if(DataTypeFile != null)
        clone.DataTypeFile = DataTypeFile.Clone();
    return clone;
}

public List<Entity> GetEntityList()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9" :
            return GetEntityList_a5e6fa7d((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetEntityList");
    }
}
public OwnList<LinkType> GetLinkTypeOwnList()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9" :
            return GetLinkTypeOwnList_a5e6fa7d((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetLinkTypeOwnList");
    }
}
public Boolean IsEntity()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9" :
            return IsEntity_a5e6fa7d((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует IsEntity");
    }
}
public Boolean IsLinkType()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9" :
            return IsLinkType_a5e6fa7d((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует IsLinkType");
    }
}
public List<CredentialUser> GetUsers()
{
    switch(CurrentStep.StepId.ToString())
    {
#line 1 "Шаг [Удаление, Удаление]. "
        case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9" :
            return GetUsers_a5e6fa7d((LocalScope)CurrentStep);
         default:
             throw new ArgumentException($"Шаг {CurrentStep} не реализует GetUsers");
    }
}
}

}

}

