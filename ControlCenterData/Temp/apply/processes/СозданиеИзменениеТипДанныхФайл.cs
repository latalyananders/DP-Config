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

public sealed partial class СозданиеИзменениеТипДанныхФайл : BaseScope , IProcessScope, IWriteStepSetEntity,IGetEntityScope,IGetCredentialUserScope,IIsEntityScope {
public СозданиеИзменениеТипДанныхФайл(IProcessContext context, IMetadataCache metadataCache, IProcessManager processManager, IProcessDataFactory dataFactory, IBinaryProvider binaryProvider)
: base (metadataCache, processManager, dataFactory, binaryProvider, context?.MessageProperty)
{
  __core_context = context;
}

public СозданиеИзменениеТипДанныхФайл()
{
    CreateLogger();
}

public override void InitStep(Guid stepId)
{
     SetCurrentStep(stepId);
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Запись, Запись]. Инициализация локальных переменных"
             case "7d6d09fb-db4d-4a8f-b824-d61df2b71f00":
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
#line 1 "Шаг [Запись, Запись]. После выполнения"
             case "7d6d09fb-db4d-4a8f-b824-d61df2b71f00":
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


public Entity GetEntity_7d6d09fb(WriteEntityScope local)
{
  return ExpressionsUtils.GetEntity(ТипДанныхФайл);
}
public bool IsEntity_7d6d09fb(WriteEntityScope local)
{
  return true;
}
public CredentialUser GetUser_7d6d09fb(WriteEntityScope local)
{
  return null;
}
public void SetEntityLink_7d6d09fb(WriteEntityScope local, (Guid typeId, Guid entityId) __core_value)
{
  local.Ссылка = new LinkType(__core_value.entityId,__core_value.typeId);
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
#line 1 "Шаг [Запись, Запись]. Логирование шага"
            case "7d6d09fb-db4d-4a8f-b824-d61df2b71f00":
            {
                WriteEntityScope local = (WriteEntityScope)CurrentStep;
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

