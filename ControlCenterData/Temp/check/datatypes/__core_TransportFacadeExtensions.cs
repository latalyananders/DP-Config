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

public static  class TransportFacadeExtensions
{
public static void SendMessage(this ITransportFacade transport, Message message, Metadata.Systems system, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, system.GetId(), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, Message message, OwnList<Metadata.Systems> systems, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, new OwnList<Guid>(systems.Select(s => s.GetId())), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, string message, Metadata.Systems system, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, system.GetId(), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, string message, OwnList<Metadata.Systems> systems, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, new OwnList<Guid>(systems.Select(s => s.GetId())), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, byte[] message, Metadata.Systems system, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, system.GetId(), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, byte[] message, OwnList<Metadata.Systems> systems, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, new OwnList<Guid>(systems.Select(s => s.GetId())), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, BaseClass message, Metadata.Systems system, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, system.GetId(), handler?.GetId() ?? null);
public static void SendMessage(this ITransportFacade transport, BaseClass message, OwnList<Metadata.Systems> systems, Metadata.Handlers? handler = null) =>
		 transport.SendMessage(message, new OwnList<Guid>(systems.Select(s => s.GetId())), handler?.GetId() ?? null);
}

}

