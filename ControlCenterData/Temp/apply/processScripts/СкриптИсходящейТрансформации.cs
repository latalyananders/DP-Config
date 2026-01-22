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

#line 1 "Код процесса СкриптИсходящейТрансформации [c92398ab-b6c9-48b6-ab70-2dcf30346d3c]"
public class OutTransformator : OutTransformBase {

protected OwnList<Systems> Receivers => new OwnList<Systems>(GetReceivers().Select(r => SystemsExtensions.ById(r.Id)));
public OwnList<Message> GetArrayOfMessage(List<Systems> systems) => GetArrayOfMessage(systems.Select(s => s.GetId()).ToList());
public OwnList<Message> GetArrayOfMessage(Systems system) => GetArrayOfMessage(system.GetId());
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

