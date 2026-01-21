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

public sealed partial class СозданиеИзменениеDataTypeFile : BaseScope , IProcessScope, IWriteStepSetEntity,IGetEntityScope,IGetCredentialUserScope,IIsEntityScope {
public СозданиеИзменениеDataTypeFile(IProcessContext context, IMetadataCache metadataCache, IProcessManager processManager, IProcessDataFactory dataFactory, IBinaryProvider binaryProvider)
: base (metadataCache, processManager, dataFactory, binaryProvider, context?.MessageProperty)
{
  __core_context = context;
}

public СозданиеИзменениеDataTypeFile()
{
    CreateLogger();
}

public override void InitStep(Guid stepId)
{
     SetCurrentStep(stepId);
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Запись, Запись]. Инициализация локальных переменных"
             case "d06e01ab-3d29-40bb-936c-5065e67b6560":
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
             case "d06e01ab-3d29-40bb-936c-5065e67b6560":
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


public Entity GetEntity_d06e01ab(WriteEntityScope local)
{
  return ExpressionsUtils.GetEntity(DataTypeFile);
}
public bool IsEntity_d06e01ab(WriteEntityScope local)
{
  return true;
}
public CredentialUser GetUser_d06e01ab(WriteEntityScope local)
{
  return null;
}
public void SetEntityLink_d06e01ab(WriteEntityScope local, (Guid typeId, Guid entityId) __core_value)
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
            case "d06e01ab-3d29-40bb-936c-5065e67b6560":
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

