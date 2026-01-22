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

public sealed partial class УдалениеDataTypeFile : BaseScope , IProcessScope, IGetEntityListScope,IGetLinkTypeOwnListScope,IIsEntityScope,IIsLinkTypeScope,IGetCredentialUsersScope {
public УдалениеDataTypeFile(IProcessContext context, IMetadataCache metadataCache, IProcessManager processManager, IProcessDataFactory dataFactory, IBinaryProvider binaryProvider)
: base (metadataCache, processManager, dataFactory, binaryProvider, context?.MessageProperty)
{
  __core_context = context;
}

public УдалениеDataTypeFile()
{
    CreateLogger();
}

public override void InitStep(Guid stepId)
{
     SetCurrentStep(stepId);
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Удаление, Удаление]. Инициализация локальных переменных"
             case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9":
                break;
#line default
         default:
             throw new ArgumentException("Неизвестный шаг " + stepId);
     }
}
public override void FinishCurrentStep()
{
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Удаление, Удаление]. После выполнения"
             case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9":
                break;
#line default
         default:
             throw new ArgumentException("Неизвестный шаг " + CurrentStep.StepId);
     }
}
/// <summary>
/// 
/// </summary>
[JsonProperty]
public SystemModels.DataTypeFile DataTypeFile
{
get => __core_DataTypeFile;
set => __core_DataTypeFile = value ?? new SystemModels.DataTypeFile();
}
[MessagePackMember(2)]
private SystemModels.DataTypeFile __core_DataTypeFile = new SystemModels.DataTypeFile();


public List<CredentialUser> GetUsers_a5e6fa7d(LocalScope local)
{
  return null;
}
public bool IsEntity_a5e6fa7d(LocalScope local)
{
  return (DataTypeFile is IDataType) || ((object)DataTypeFile is IOwnList olist && olist.IsAssignableElementType(typeof(IDataType)));
}
public bool IsLinkType_a5e6fa7d(LocalScope local)
{
  return (DataTypeFile is LinkType) || ((object)DataTypeFile is IOwnList olist && olist.IsAssignableElementType(typeof(LinkType)));
}
public List<Entity> GetEntityList_a5e6fa7d(LocalScope local)
{
  return ExpressionsUtils.GetEntityList(DataTypeFile);
}
public OwnList<LinkType> GetLinkTypeOwnList_a5e6fa7d(LocalScope local)
{
  return ExpressionsUtils.GetLinkTypeOwnList(DataTypeFile);
}

public override bool TryGetLogDetails(out string logDetails, out string errorMessage)
{
     bool result = true;
     logDetails = string.Empty;
     errorMessage = null;
    try
    {
         switch(CurrentStep.StepId.ToString())
         {
#line 1 "Шаг [Удаление, Удаление]. Логирование шага"
            case "a5e6fa7d-0478-492f-814e-eb28bebbd3a9":
            {
                LocalScope local = (LocalScope)CurrentStep;
                break;
            }
            default:
                result = false;
                errorMessage = $"В шаге {CurrentStep} логгирование пользователем не предусмотрено";
                break;
         }
    }
    catch(Exception ex)
    {
        result = false;
        errorMessage = ex.Message;
    }
    return result;
}
}


}

}

