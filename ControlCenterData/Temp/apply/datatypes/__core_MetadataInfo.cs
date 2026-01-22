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

using SystemModels;

public static  class MetadataInfo
{
    public static readonly SystemTypeSite TypeSite;

    static MetadataInfo()
    {
        TypeSite = new SystemTypeSite();
        TypeSite.Add<Metadata.Handlers>();
        TypeSite.Add<Metadata.Enums>();
        TypeSite.Add<Metadata.DataTypes>();
        TypeSite.Add<Metadata.Dynamics>();
        TypeSite.Add<Metadata.Classifiers>();
        TypeSite.Add<Metadata.Roles>();
        TypeSite.Add<Metadata.SM>();
        TypeSite.Add<Metadata.Systems>();
        TypeSite.Add<Metadata.Functions>();
    }

    public static T GetSystemEnum<T>(JToken jToken)
    {
        if (!jToken.IsNull())
        {
            var map = TypeSite.Get<T>();
            var id = (Guid)jToken;
            return map.GetValue(id);
        }

        return default(T);
    }

    public static bool TryGetSystemEnum<T>(string name, JObject jObject, out T value)
    {
        var jToken = jObject[name];
        if (jToken != null)
        {
            try
            {
                value = GetSystemEnum<T>(jToken);
                return true;
            }
            catch
            {
                //ignore
            }
        }

        value = default(T);
        return false;
    }

    public static Metadata.Enums SearchEnum(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.Enums>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.Enums SearchEnum(Guid id)
    {
        var map = TypeSite.Get<Metadata.Enums>();
        return map.GetValue(id);
    }

    public static Metadata.DataTypes SearchDataType(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.DataTypes>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.DataTypes SearchDataType(Guid id)
    {
        var map = TypeSite.Get<Metadata.DataTypes>();
        return map.GetValue(id);
    }

    public static Metadata.Dynamics SearchDynamic(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.Dynamics>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.Dynamics SearchDynamic(Guid id)
    {
        var map = TypeSite.Get<Metadata.Dynamics>();
        return map.GetValue(id);
    }

    public static Metadata.Classifiers SearchClassifier(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.Classifiers>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.Classifiers SearchClassifier(Guid id)
    {
        var map = TypeSite.Get<Metadata.Classifiers>();
        return map.GetValue(id);
    }

    public static Metadata.Roles SearchRole(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.Roles>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.Roles SearchRole(Guid id)
    {
        var map = TypeSite.Get<Metadata.Roles>();
        return map.GetValue(id);
    }

    public static Metadata.SM SearchSM(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.SM>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.SM SearchSM(Guid id)
    {
        var map = TypeSite.Get<Metadata.SM>();
        return map.GetValue(id);
    }

    public static Metadata.Systems SearchSystem(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.Systems>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.Systems SearchSystem(Guid id)
    {
        var map = TypeSite.Get<Metadata.Systems>();
        return map.GetValue(id);
    }

    public static Metadata.Functions SearchFunction(string name, bool caseInsensitive = false)
    {
        var map = TypeSite.Get<Metadata.Functions>();
        return map.GetValue(name, caseInsensitive);
    }

    public static Metadata.Functions SearchFunction(Guid id)
    {
        var map = TypeSite.Get<Metadata.Functions>();
        return map.GetValue(id);
    }


}

}

