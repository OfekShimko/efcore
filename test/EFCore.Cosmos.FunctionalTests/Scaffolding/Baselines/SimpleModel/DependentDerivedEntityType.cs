// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Cosmos.Storage.Internal;
using Microsoft.EntityFrameworkCore.Cosmos.ValueGeneration.Internal;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Json;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Newtonsoft.Json.Linq;

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
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentDerived<int>",
                typeof(CompiledModelTestBase.DependentDerived<int>),
                baseEntityType,
                discriminatorProperty: "Discriminator",
                discriminatorValue: "DependentDerived",
                propertyCount: 5,
                keyCount: 2);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(CompiledModelTestBase.AbstractBase).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<int>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.SetGetter(
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity),
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) == 0,
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance),
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(instance) == 0);
            id.SetSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, int value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(entity) = value);
            id.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<int>(id, 0),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<int>(id, 0),
                (ValueBuffer valueBuffer) => valueBuffer[0]);
            id.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: -1);
            id.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                keyComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                providerValueComparer: new ValueComparer<int>(
                    (int v1, int v2) => v1 == v2,
                    (int v) => v,
                    (int v) => v),
                clrType: typeof(int),
                jsonValueReaderWriter: JsonInt32ReaderWriter.Instance);
            id.SetCurrentValueComparer(new EntryCurrentValueComparer<int>(id));
            id.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id", "TestNamespace") });

            var data = runtimeEntityType.AddProperty(
                "Data",
                typeof(string),
                propertyInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetProperty("Data", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentDerived<int>).GetField("<Data>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            data.SetGetter(
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity),
                (CompiledModelTestBase.DependentDerived<int> entity) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) == null,
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(instance),
                (CompiledModelTestBase.DependentDerived<int> instance) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(instance) == null);
            data.SetSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, string value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) = value);
            data.SetMaterializationSetter(
                (CompiledModelTestBase.DependentDerived<int> entity, string value) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(entity) = value);
            data.SetAccessors(
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data((CompiledModelTestBase.DependentDerived<int>)entry.Entity),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<string>(data, 1),
                (InternalEntityEntry entry) => entry.GetCurrentValue<string>(data),
                (ValueBuffer valueBuffer) => valueBuffer[1]);
            data.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            data.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                clrType: typeof(string),
                jsonValueReaderWriter: JsonStringReaderWriter.Instance);
            data.AddRuntimeAnnotation("UnsafeAccessors", new[] { ("DependentDerivedEntityType.UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data", "TestNamespace") });

            var discriminator = runtimeEntityType.AddProperty(
                "Discriminator",
                typeof(string),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new DiscriminatorValueGeneratorFactory().Create);
            discriminator.SetPropertyIndexes(
                index: 2,
                originalValueIndex: 2,
                shadowIndex: 0,
                relationshipIndex: -1,
                storeGenerationIndex: -1);
            discriminator.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                clrType: typeof(string),
                jsonValueReaderWriter: JsonStringReaderWriter.Instance);

            var __id = runtimeEntityType.AddProperty(
                "__id",
                typeof(string),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new IdValueGeneratorFactory().Create);
            __id.SetPropertyIndexes(
                index: 3,
                originalValueIndex: 3,
                shadowIndex: 1,
                relationshipIndex: 1,
                storeGenerationIndex: -1);
            __id.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                keyComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                providerValueComparer: new ValueComparer<string>(
                    (string v1, string v2) => v1 == v2,
                    (string v) => v.GetHashCode(),
                    (string v) => v),
                clrType: typeof(string),
                jsonValueReaderWriter: JsonStringReaderWriter.Instance);
            __id.SetCurrentValueComparer(new EntryCurrentValueComparer<string>(__id));
            __id.AddAnnotation("Cosmos:PropertyName", "id");

            var __jObject = runtimeEntityType.AddProperty(
                "__jObject",
                typeof(JObject),
                nullable: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            __jObject.SetPropertyIndexes(
                index: 4,
                originalValueIndex: 4,
                shadowIndex: 2,
                relationshipIndex: -1,
                storeGenerationIndex: 0);
            __jObject.TypeMapping = CosmosTypeMapping.Default.Clone(
                comparer: new ValueComparer<JObject>(
                    (JObject v1, JObject v2) => object.Equals(v1, v2),
                    (JObject v) => v.GetHashCode(),
                    (JObject v) => v),
                keyComparer: new ValueComparer<JObject>(
                    (JObject v1, JObject v2) => object.Equals(v1, v2),
                    (JObject v) => v.GetHashCode(),
                    (JObject v) => v),
                providerValueComparer: new ValueComparer<JObject>(
                    (JObject v1, JObject v2) => object.Equals(v1, v2),
                    (JObject v) => v.GetHashCode(),
                    (JObject v) => v),
                clrType: typeof(JObject));
            __jObject.AddAnnotation("Cosmos:PropertyName", "");

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            var key0 = runtimeEntityType.AddKey(
                new[] { __id });

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var id = runtimeEntityType.FindProperty("Id")!;
            var data = runtimeEntityType.FindProperty("Data")!;
            var discriminator = runtimeEntityType.FindProperty("Discriminator")!;
            var __id = runtimeEntityType.FindProperty("__id")!;
            var __jObject = runtimeEntityType.FindProperty("__jObject")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentDerived<int>)source.Entity;
                    return (ISnapshot)new Snapshot<int, string, string, string, JObject>(((ValueComparer<int>)id.GetValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), source.GetCurrentValue<string>(data) == null ? null : ((ValueComparer<string>)data.GetValueComparer()).Snapshot(source.GetCurrentValue<string>(data)), source.GetCurrentValue<string>(discriminator) == null ? null : ((ValueComparer<string>)discriminator.GetValueComparer()).Snapshot(source.GetCurrentValue<string>(discriminator)), source.GetCurrentValue<string>(__id) == null ? null : ((ValueComparer<string>)__id.GetValueComparer()).Snapshot(source.GetCurrentValue<string>(__id)), source.GetCurrentValue<JObject>(__jObject) == null ? null : ((ValueComparer<JObject>)__jObject.GetValueComparer()).Snapshot(source.GetCurrentValue<JObject>(__jObject)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<JObject>(default(JObject) == null ? null : ((ValueComparer<JObject>)__jObject.GetValueComparer()).Snapshot(default(JObject))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<JObject>(default(JObject)));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => (ISnapshot)new Snapshot<string, string, JObject>(source.ContainsKey("Discriminator") ? (string)source["Discriminator"] : null, source.ContainsKey("__id") ? (string)source["__id"] : null, source.ContainsKey("__jObject") ? (JObject)source["__jObject"] : null));
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => (ISnapshot)new Snapshot<string, string, JObject>(default(string), default(string), default(JObject)));
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (CompiledModelTestBase.DependentDerived<int>)source.Entity;
                    return (ISnapshot)new Snapshot<int, string>(((ValueComparer<int>)id.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<int>(id)), source.GetCurrentValue<string>(__id) == null ? null : ((ValueComparer<string>)__id.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<string>(__id)));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 5,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 5,
                shadowCount: 3,
                relationshipCount: 2,
                storeGeneratedCount: 1);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentBase1_Id(CompiledModelTestBase.DependentDerived<int> @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Data>k__BackingField")]
        public static extern ref string UnsafeAccessor_Microsoft_EntityFrameworkCore_Scaffolding_DependentDerived1_Data(CompiledModelTestBase.DependentDerived<int> @this);
    }
}
