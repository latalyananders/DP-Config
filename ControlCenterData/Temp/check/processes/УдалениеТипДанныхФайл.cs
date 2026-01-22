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

public sealed partial class УдалениеТипДанныхФайл : BaseScope , IProcessScope, IGetEntityListScope,IGetLinkTypeOwnListScope,IIsEntityScope,IIsLinkTypeScope,IGetCredentialUsersScope {
public УдалениеТипДанныхФайл(IProcessContext context, IMetadataCache metadataCache, IProcessManager processManager, IProcessDataFactory dataFactory, IBinaryProvider binaryProvider)
: base (metadataCache, processManager, dataFactory, binaryProvider, context?.MessageProperty)
{
  __core_context = context;
}

public УдалениеТипДанныхФайл()
{
    CreateLogger();
}

public override void InitStep(Guid stepId)
{
     SetCurrentStep(stepId);
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Удаление, Удаление]. Инициализация локальных переменных"
             case "33d45886-fd3d-4f0f-90f5-adf7fdd95829":
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
             case "33d45886-fd3d-4f0f-90f5-adf7fdd95829":
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
public SystemModels.ТипДанныхФайл ТипДанныхФайл
{
get => __core_ТипДанныхФайл;
set => __core_ТипДанныхФайл = value ?? new SystemModels.ТипДанныхФайл();
}
[MessagePackMember(2)]
private SystemModels.ТипДанныхФайл __core_ТипДанныхФайл = new SystemModels.ТипДанныхФайл();


public List<CredentialUser> GetUsers_33d45886(LocalScope local)
{
  return null;
}
public bool IsEntity_33d45886(LocalScope local)
{
  return (ТипДанныхФайл is IDataType) || ((object)ТипДанныхФайл is IOwnList olist && olist.IsAssignableElementType(typeof(IDataType)));
}
public bool IsLinkType_33d45886(LocalScope local)
{
  return (ТипДанныхФайл is LinkType) || ((object)ТипДанныхФайл is IOwnList olist && olist.IsAssignableElementType(typeof(LinkType)));
}
public List<Entity> GetEntityList_33d45886(LocalScope local)
{
  return ExpressionsUtils.GetEntityList(ТипДанныхФайл);
}
public OwnList<LinkType> GetLinkTypeOwnList_33d45886(LocalScope local)
{
  return ExpressionsUtils.GetLinkTypeOwnList(ТипДанныхФайл);
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
            case "33d45886-fd3d-4f0f-90f5-adf7fdd95829":
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

