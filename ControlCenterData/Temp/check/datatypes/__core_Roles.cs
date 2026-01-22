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

namespace Metadata {

using SystemModels;

[SystemTypeEnumAttribute(SystemEnumeration.Role)]
public enum Roles
{
    Empty = 0
}

public static  class RolesExtensions
{
    private static readonly ISystemTypeMap<Metadata.Roles> Map;

    static RolesExtensions()
    {
        Map = MetadataInfo.TypeSite.Get<Metadata.Roles>();
    }

    public static Guid GetId(this Roles type) => Map.GetTypeId(type);

    public static Roles ById(Guid id) => Map.GetValue(id);

    public static string GetName(this Roles type) => type.ToString();

    public static CredentialRole GetRoleInfo(this Metadata.Roles role)
    {
        return TypesEnvironment.GetRole(role.GetId());
    }

    public static bool IsBusinessRole(this Metadata.Roles role)
    {
        return TypesEnvironment.GetRole(role.GetId()).IsBusinessRole;
    }

}

}

