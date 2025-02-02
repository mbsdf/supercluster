// Copyright 2019 Stellar Development Foundation and contributors. Licensed
// under the Apache License, Version 2.0. See the COPYING file at the root
// of this distribution or at http://www.apache.org/licenses/LICENSE-2.0

module StellarMission

open MissionBootAndSync
open MissionSimplePayment
open MissionComplexTopology
open MissionInMemoryMode
open MissionLoadGeneration
open MissionLoadGenerationWithSpikes
open MissionLoadGenerationWithTxSetLimit
open MissionMixedImageLoadGeneration
open MissionBenchmarkBaseline
open MissionBenchmarkConsensusOnly
open MissionBenchmarkIncreaseTxRate
open MissionHistoryGenerateAndCatchup
open MissionHistoryPubnetMinimumCatchup
open MissionHistoryPubnetRecentCatchup
open MissionHistoryPubnetCompleteCatchup
open MissionHistoryPubnetParallelCatchup
open MissionHistoryPubnetParallelCatchupExtrawide
open MissionHistoryPubnetPerformance
open MissionHistoryTestnetMinimumCatchup
open MissionHistoryTestnetRecentCatchup
open MissionHistoryTestnetCompleteCatchup
open MissionHistoryTestnetParallelCatchup
open MissionHistoryTestnetPerformance
open MissionVersionMixConsensus
open MissionVersionMixNewCatchupToOld
open MissionVersionMixOldCatchupToNew
open MissionProtocolUpgradeTestnet
open MissionProtocolUpgradePubnet
open MissionProtocolUpgradeWithLoad
open MissionDatabaseInplaceUpgrade
open MissionAcceptanceUnitTests
open MissionSimulatePubnet
open MissionSimulatePubnetTier1Perf
open StellarMissionContext
open MissionSorobanLoadGeneration

type Mission = (MissionContext -> unit)


let allMissions : Map<string, Mission> =
    Map.ofSeq [| ("BootAndSync", bootAndSync)
                 ("SimplePayment", simplePayment)
                 ("ComplexTopology", complexTopology)
                 ("LoadGeneration", loadGeneration)
                 ("LoadGenerationWithSpikes", loadGenerationWithSpikes)
                 ("LoadGenerationWithTxSetLimit", loadGenerationWithTxSetLimit)
                 ("MixedImageLoadGenerationWithOldImageMajority", mixedImageLoadGenerationWithOldImageMajority)
                 ("MixedImageLoadGenerationWithNewImageMajority", mixedImageLoadGenerationWithNewImageMajority)
                 ("InMemoryMode", runInMemoryMode)
                 ("BenchmarkBaseline", benchmarkBaseline)
                 ("BenchmarkConsensusOnly", benchmarkConsensusOnly)
                 ("BenchmarkIncreaseTxRate", benchmarkIncreaseTxRate)
                 ("HistoryGenerateAndCatchup", historyGenerateAndCatchup)
                 ("HistoryPubnetMinimumCatchup", historyPubnetMinimumCatchup)
                 ("HistoryPubnetRecentCatchup", historyPubnetRecentCatchup)
                 ("HistoryPubnetCompleteCatchup", historyPubnetCompleteCatchup)
                 ("HistoryPubnetParallelCatchup", historyPubnetParallelCatchup)
                 ("HistoryPubnetParallelCatchupExtrawide", historyPubnetParallelCatchupExtrawide)
                 ("HistoryPubnetPerformance", historyPubnetPerformance)
                 ("HistoryTestnetMinimumCatchup", historyTestnetMinimumCatchup)
                 ("HistoryTestnetRecentCatchup", historyTestnetRecentCatchup)
                 ("HistoryTestnetCompleteCatchup", historyTestnetCompleteCatchup)
                 ("HistoryTestnetParallelCatchup", historyTestnetParallelCatchup)
                 ("HistoryTestnetPerformance", historyTestnetPerformance)
                 ("VersionMixConsensus", versionMixConsensus)
                 ("VersionMixNewCatchupToOld", versionMixNewCatchupToOld)
                 ("VersionMixOldCatchupToNew", versionMixOldCatchupToNew)
                 ("ProtocolUpgradeTestnet", protocolUpgradeTestnet)
                 ("ProtocolUpgradePubnet", protocolUpgradePubnet)
                 ("ProtocolUpgradeWithLoad", protocolUpgradeWithLoad)
                 ("DatabaseInplaceUpgrade", databaseInplaceUpgrade)
                 ("AcceptanceUnitTests", acceptanceUnitTests)
                 ("SimulatePubnet", simulatePubnet)
                 ("SimulatePubnetTier1Perf", simulatePubnetTier1Perf)
                 ("SorobanLoadGeneration"), sorobanLoadGeneration |]
