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

#line 1 "Код процесса СкриптВыбораСхемыОбработки [f976808d-d0cf-488e-8041-875a6960aefa]"
public class Qualifier : QualifierBase {

private readonly OwnList<Functions> DefineFunctions = new OwnList<Functions>();

public override List<Guid> GetFunctions() => DefineFunctions.Distinct().Select(f => f.GetId()).Where(g => g != default).ToList();

public void SetFunction(Functions function) => DefineFunctions.Add(function);

public OwnList<Functions> CalculateFunctions() => new OwnList<Functions>(TypesEnvironment.GetDataTypeMatchedAutoStartFunctions(InitMessage.GetDataTypeId()).Union(TypesEnvironment.GetDefaultAutoStartFunctions()).Select(f => FunctionsExtensions.ById(f)));
public OwnList<Functions> CalculateFunctions(Message message) => new OwnList<Functions>(TypesEnvironment.GetDataTypeMatchedAutoStartFunctions(message.GetDataTypeId()).Union(TypesEnvironment.GetDefaultAutoStartFunctions()).Select(f => FunctionsExtensions.ById(f)));
public OwnList<Functions> CalculateFunctions(Metadata.DataTypes type) => new OwnList<Functions>(TypesEnvironment.GetDataTypeMatchedAutoStartFunctions(type.GetId()).Union(TypesEnvironment.GetDefaultAutoStartFunctions()).Select(f => FunctionsExtensions.ById(f)));
public OwnList<Functions> CalculateFunctions(Metadata.SM type) => new OwnList<Functions>(TypesEnvironment.GetDataTypeMatchedAutoStartFunctions(type.GetId()).Union(TypesEnvironment.GetDefaultAutoStartFunctions()).Select(f => FunctionsExtensions.ById(f)));
public override bool IsEmpty => true;
bool IsNullOrDefault<T>(T __core_item)
{
    if (typeof(T).IsValueType)
        return __core_item.Equals(default(T));
    return __core_item == null;
}

public override void InvokeScript(Guid user, ICredentialQuery credential, IDataBankQuery databank, IMessageStorageModuleFacade messageStorage)
{
}
public override void Clear()
{
}
}

}

