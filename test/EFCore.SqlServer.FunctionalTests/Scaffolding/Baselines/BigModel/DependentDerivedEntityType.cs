// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentDerivedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<byte?>",
                typeof(CompiledModelTestBase.DependentDerived<byte?>),
                baseEntityType,
                discriminatorProperty: "EnumDiscriminator",
                discriminatorValue: CompiledModelTestBase.Enum1.Two,
                propertyCount: 2);

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(CompiledModelTestBase.DependentDerived<byte?>).GetProperty("Data", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentDerived<byte?>).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20,
                unicode: false);
            data.SetGetter(
                (CompiledModelTestBase.DependentDerived<Nullable<byte>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity),
                (CompiledModelTestBase.DependentDerived<Nullable<byte>> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) == null,
                (CompiledModelTestBase.DependentDerived<Nullable<byte>> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(instance),
                (CompiledModelTestBase.DependentDerived<Nullable<byte>> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(instance) == null);
            data.SetSetter(
                (CompiledModelTestBase.DependentDerived<Nullable<byte>> entity, string value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) = value);
            data.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<Nullable<byte>> entity, string value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) = value);
            data.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data((CompiledModelTestBase.DependentDerived<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data((CompiledModelTestBase.DependentDerived<Nullable<byte>>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(data, 4),
                (InternalEntityEntry entry) => entry.GetCurrentValue<string>(data),
                (ValueBuffer valueBuffer) => valueBuffer[4]);
            data.SetPropertyIndexes(
                index: 4,
                originalValueIndex: 4,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            data.TypeMapping = SqlServerStringTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => ((object)v).GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => ((object)v).GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => ((object)v).GetHashCode(),
                    (string v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "char(20)",
                    size: 20,
                    fixedLength: true,
                    dbType: System.Data.DbType.AnsiStringFixedLength));
            data.AddAnnotation("Relational:IsFixedLength", true);
            data.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);
            data.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data", "TestNamespace") });

            var money = runtimeEntityType.AddProperty(
                "Money",
                typeof(decimal),
                precision: 9,
                scale: 3,
                sentinel: 0m);
            money.SetPropertyIndexes(
                index: 5,
                originalValueIndex: 5,
                shadowIndex: 3,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            money.TypeMapping = SqlServerDecimalTypeMapping.Default.Clone(
                comparer: new ValueComparer<decimal>(
                    (decimal v1, decimal v2) => v1 == v2,
                    (decimal v) => ((object)v).GetHashCode(),
                    (decimal v) => v),
                keyComparer: new ValueComparer<decimal>(
                    (decimal v1, decimal v2) => v1 == v2,
                    (decimal v) => ((object)v).GetHashCode(),
                    (decimal v) => v),
                providerValueComparer: new ValueComparer<decimal>(
                    (decimal v1, decimal v2) => v1 == v2,
                    (decimal v) => ((object)v).GetHashCode(),
                    (decimal v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "decimal(9,3)",
                    precision: 9,
                    scale: 3));
            money.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var principalId = runtimeEntityType.FindProperty("PrincipalId")!;
            var principalAlternateId = runtimeEntityType.FindProperty("PrincipalAlternateId")!;
            var enumDiscriminator = runtimeEntityType.FindProperty("EnumDiscriminator")!;
            var id = runtimeEntityType.FindProperty("Id")!;
            var data = runtimeEntityType.FindProperty("Data")!;
            var money = runtimeEntityType.FindProperty("Money")!;
            var principal = runtimeEntityType.FindNavigation("Principal")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity8 = (CompiledModelTestBase.DependentDerived<Nullable<byte>>)source.Entity;
                    return (ISnapshot)new Snapshot<long, Guid, CompiledModelTestBase.Enum1, Nullable<byte>, string, decimal>(((ValueComparer<long>)((IProperty)principalId).GetValueComparer()).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)((IProperty)principalAlternateId).GetValueComparer()).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), ((ValueComparer<CompiledModelTestBase.Enum1>)((IProperty)enumDiscriminator).GetValueComparer()).Snapshot(source.GetCurrentValue<CompiledModelTestBase.Enum1>(enumDiscriminator)), source.GetCurrentValue<Nullable<byte>>(id) == null ? null : ((ValueComparer<Nullable<byte>>)((IProperty)id).GetValueComparer()).Snapshot(source.GetCurrentValue<Nullable<byte>>(id)), source.GetCurrentValue<string>(data) == null ? null : ((ValueComparer<string>)((IProperty)data).GetValueComparer()).Snapshot(source.GetCurrentValue<string>(data)), ((ValueComparer<decimal>)((IProperty)money).GetValueComparer()).Snapshot(source.GetCurrentValue<decimal>(money)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<long, Guid>(((ValueComparer<long>)((IProperty)principalId).GetValueComparer()).Snapshot(default(long)), ((ValueComparer<Guid>)((IProperty)principalAlternateId).GetValueComparer()).Snapshot(default(Guid))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<long, Guid>(default(long), default(Guid)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => (ISnapshot)new Snapshot<long, Guid, CompiledModelTestBase.Enum1, decimal>(source.ContainsKey("PrincipalId") ? (long)source["PrincipalId"] : 0L, source.ContainsKey("PrincipalAlternateId") ? (Guid)source["PrincipalAlternateId"] : new Guid("00000000-0000-0000-0000-000000000000"), source.ContainsKey("EnumDiscriminator") ? (CompiledModelTestBase.Enum1)source["EnumDiscriminator"] : CompiledModelTestBase.Enum1.Default, source.ContainsKey("Money") ? (decimal)source["Money"] : 0M));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => (ISnapshot)new Snapshot<long, Guid, CompiledModelTestBase.Enum1, decimal>(default(long), default(Guid), default(CompiledModelTestBase.Enum1), default(decimal)));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity8 = (CompiledModelTestBase.DependentDerived<Nullable<byte>>)source.Entity;
                    return (ISnapshot)new Snapshot<long, Guid, object>(((ValueComparer<long>)((IProperty)principalId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<long>(principalId)), ((ValueComparer<Guid>)((IProperty)principalAlternateId).GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Guid>(principalAlternateId)), DependentBaseEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Principal(entity8));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 6,
                navigationCount: 1,
                complexPropertyCount: 0,
                originalValueCount: 6,
                shadowCount: 4,
                relationshipCount: 3,
                storeGeneratedCount: 2);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "DependentBase<byte?>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Data>k__BackingField")]
        public static extern ref string UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(CompiledModelTestBase.DependentDerived<byte?> @this);
    }
}
