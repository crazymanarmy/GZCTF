﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Storage.Internal.Mapping;

#pragma warning disable 219, 612, 618
#nullable disable

namespace GZCTF.Models.Data.Compiled
{
    internal partial class GameInstanceEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "GZCTF.Models.Data.GameInstance",
                typeof(GameInstance),
                baseEntityType);

            var challengeId = runtimeEntityType.AddProperty(
                "ChallengeId",
                typeof(int),
                propertyInfo: typeof(GameInstance).GetProperty("ChallengeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GameInstance).GetField("<ChallengeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            challengeId.TypeMapping = IntTypeMapping.Default.Clone(
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
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "integer"));
            challengeId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var participationId = runtimeEntityType.AddProperty(
                "ParticipationId",
                typeof(int),
                propertyInfo: typeof(GameInstance).GetProperty("ParticipationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GameInstance).GetField("<ParticipationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            participationId.TypeMapping = IntTypeMapping.Default.Clone(
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
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "integer"));
            participationId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var containerId = runtimeEntityType.AddProperty(
                "ContainerId",
                typeof(Guid?),
                propertyInfo: typeof(Instance).GetProperty("ContainerId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<ContainerId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            containerId.TypeMapping = GuidTypeMapping.Default.Clone(
                comparer: new ValueComparer<Guid?>(
                    (Nullable<Guid> v1, Nullable<Guid> v2) => v1.HasValue && v2.HasValue && (Guid)v1 == (Guid)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<Guid> v) => v.HasValue ? ((Guid)v).GetHashCode() : 0,
                    (Nullable<Guid> v) => v.HasValue ? (Nullable<Guid>)(Guid)v : default(Nullable<Guid>)),
                keyComparer: new ValueComparer<Guid?>(
                    (Nullable<Guid> v1, Nullable<Guid> v2) => v1.HasValue && v2.HasValue && (Guid)v1 == (Guid)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<Guid> v) => v.HasValue ? ((Guid)v).GetHashCode() : 0,
                    (Nullable<Guid> v) => v.HasValue ? (Nullable<Guid>)(Guid)v : default(Nullable<Guid>)),
                providerValueComparer: new ValueComparer<Guid?>(
                    (Nullable<Guid> v1, Nullable<Guid> v2) => v1.HasValue && v2.HasValue && (Guid)v1 == (Guid)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<Guid> v) => v.HasValue ? ((Guid)v).GetHashCode() : 0,
                    (Nullable<Guid> v) => v.HasValue ? (Nullable<Guid>)(Guid)v : default(Nullable<Guid>)),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "uuid"));
            containerId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var flagId = runtimeEntityType.AddProperty(
                "FlagId",
                typeof(int?),
                propertyInfo: typeof(Instance).GetProperty("FlagId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<FlagId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            flagId.TypeMapping = IntTypeMapping.Default.Clone(
                comparer: new ValueComparer<int?>(
                    (Nullable<int> v1, Nullable<int> v2) => v1.HasValue && v2.HasValue && (int)v1 == (int)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<int> v) => v.HasValue ? (int)v : 0,
                    (Nullable<int> v) => v.HasValue ? (Nullable<int>)(int)v : default(Nullable<int>)),
                keyComparer: new ValueComparer<int?>(
                    (Nullable<int> v1, Nullable<int> v2) => v1.HasValue && v2.HasValue && (int)v1 == (int)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<int> v) => v.HasValue ? (int)v : 0,
                    (Nullable<int> v) => v.HasValue ? (Nullable<int>)(int)v : default(Nullable<int>)),
                providerValueComparer: new ValueComparer<int?>(
                    (Nullable<int> v1, Nullable<int> v2) => v1.HasValue && v2.HasValue && (int)v1 == (int)v2 || !v1.HasValue && !v2.HasValue,
                    (Nullable<int> v) => v.HasValue ? (int)v : 0,
                    (Nullable<int> v) => v.HasValue ? (Nullable<int>)(int)v : default(Nullable<int>)),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "integer"));
            flagId.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var isLoaded = runtimeEntityType.AddProperty(
                "IsLoaded",
                typeof(bool),
                propertyInfo: typeof(Instance).GetProperty("IsLoaded", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<IsLoaded>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isLoaded.TypeMapping = NpgsqlBoolTypeMapping.Default.Clone(
                comparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                keyComparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                providerValueComparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v));
            isLoaded.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var isSolved = runtimeEntityType.AddProperty(
                "IsSolved",
                typeof(bool),
                propertyInfo: typeof(Instance).GetProperty("IsSolved", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<IsSolved>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isSolved.TypeMapping = NpgsqlBoolTypeMapping.Default.Clone(
                comparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                keyComparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v),
                providerValueComparer: new ValueComparer<bool>(
                    (bool v1, bool v2) => v1 == v2,
                    (bool v) => v.GetHashCode(),
                    (bool v) => v));
            isSolved.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var lastContainerOperation = runtimeEntityType.AddProperty(
                "LastContainerOperation",
                typeof(DateTimeOffset),
                propertyInfo: typeof(Instance).GetProperty("LastContainerOperation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<LastContainerOperation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
            lastContainerOperation.TypeMapping = NpgsqlTimestampTzTypeMapping.Default.Clone(
                comparer: new ValueComparer<DateTimeOffset>(
                    (DateTimeOffset v1, DateTimeOffset v2) => v1.EqualsExact(v2),
                    (DateTimeOffset v) => v.GetHashCode(),
                    (DateTimeOffset v) => v),
                keyComparer: new ValueComparer<DateTimeOffset>(
                    (DateTimeOffset v1, DateTimeOffset v2) => v1.EqualsExact(v2),
                    (DateTimeOffset v) => v.GetHashCode(),
                    (DateTimeOffset v) => v),
                providerValueComparer: new ValueComparer<DateTimeOffset>(
                    (DateTimeOffset v1, DateTimeOffset v2) => v1.EqualsExact(v2),
                    (DateTimeOffset v) => v.GetHashCode(),
                    (DateTimeOffset v) => v),
                clrType: typeof(DateTimeOffset),
                jsonValueReaderWriter: new NpgsqlTimestampTzTypeMapping.NpgsqlJsonTimestampTzDateTimeOffsetReaderWriter());
            lastContainerOperation.AddAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { challengeId, participationId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { containerId },
                unique: true);

            var index0 = runtimeEntityType.AddIndex(
                new[] { flagId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { participationId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ChallengeId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var challenge = declaringEntityType.AddNavigation("Challenge",
                runtimeForeignKey,
                onDependent: true,
                typeof(GameChallenge),
                propertyInfo: typeof(GameInstance).GetProperty("Challenge", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GameInstance).GetField("<Challenge>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true);

            var instances = principalEntityType.AddNavigation("Instances",
                runtimeForeignKey,
                onDependent: false,
                typeof(List<GameInstance>),
                propertyInfo: typeof(GameChallenge).GetProperty("Instances", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GameChallenge).GetField("<Instances>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ContainerId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.SetNull,
                unique: true);

            var container = declaringEntityType.AddNavigation("Container",
                runtimeForeignKey,
                onDependent: true,
                typeof(Container),
                propertyInfo: typeof(Instance).GetProperty("Container", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<Container>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true);

            var gameInstance = principalEntityType.AddNavigation("GameInstance",
                runtimeForeignKey,
                onDependent: false,
                typeof(GameInstance),
                propertyInfo: typeof(Container).GetProperty("GameInstance", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Container).GetField("<GameInstance>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("FlagId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.SetNull);

            var flagContext = declaringEntityType.AddNavigation("FlagContext",
                runtimeForeignKey,
                onDependent: true,
                typeof(FlagContext),
                propertyInfo: typeof(Instance).GetProperty("FlagContext", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Instance).GetField("<FlagContext>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ParticipationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            var participation = declaringEntityType.AddNavigation("Participation",
                runtimeForeignKey,
                onDependent: true,
                typeof(Participation),
                propertyInfo: typeof(GameInstance).GetProperty("Participation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GameInstance).GetField("<Participation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var instances = principalEntityType.AddNavigation("Instances",
                runtimeForeignKey,
                onDependent: false,
                typeof(List<GameInstance>),
                propertyInfo: typeof(Participation).GetProperty("Instances", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Participation).GetField("<Instances>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "GameInstances");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}