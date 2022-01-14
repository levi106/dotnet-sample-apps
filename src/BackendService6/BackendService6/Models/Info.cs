namespace BackendService6.Models;

public struct ProcessorInfo
{
    public int ProcessorCount { get; init; } = Environment.ProcessorCount;
}

public struct MemoryInfo
{
    public MemoryInfo()
    {
        TotalAllocatedBytes = GC.GetTotalAllocatedBytes();
        TotalMemory = GC.GetTotalMemory(false);
        Gen0CollectionCount = GC.CollectionCount(0);
        Gen1CollectionCount = GC.CollectionCount(1);
        Gen2CollectionCount = GC.CollectionCount(2);
    }

    public long TotalAllocatedBytes { get; init; }
    public long TotalMemory { get; init; }
    public int Gen0CollectionCount { get; init; }
    public int Gen1CollectionCount { get; init; }
    public int Gen2CollectionCount { get; init; }
}

public struct GCMemoryInfo
{
    public GCMemoryInfo(System.GCMemoryInfo info)
    {
        Compacted = info.Compacted;
        Concurrent = info.Concurrent;
        FinalizationPendingCount = info.FinalizationPendingCount;
        FragmentedBytes = info.FragmentedBytes;
        Generation = info.Generation;
        HeapSizeBytes = info.HeapSizeBytes;
        HighMemoryLoadThresholdBytes = info.HighMemoryLoadThresholdBytes;
        Index = info.Index;
        MemoryLoadBytes = info.MemoryLoadBytes;
        PauseTimePercentage = info.PauseTimePercentage;
        PinnedObjectsCount = info.PinnedObjectsCount;
        PromotedBytes = info.PromotedBytes;
        TotalAvailableMemoryBytes = info.TotalAvailableMemoryBytes;
        TotalCommittedBytes = info.TotalCommittedBytes;
    }

    public bool Compacted { get; init; }
    public bool Concurrent { get; init; }
    public long FinalizationPendingCount { get; init; }
    public long FragmentedBytes { get; init; }
    public int Generation { get; init; }
    public long HeapSizeBytes { get; init; }
    public long HighMemoryLoadThresholdBytes { get; init; }
    public long Index { get; init; }
    public long MemoryLoadBytes { get; init; }
    public double PauseTimePercentage { get; init; }
    public long PinnedObjectsCount { get; init; }
    public long PromotedBytes { get; init; }
    public long TotalAvailableMemoryBytes { get; init; }
    public long TotalCommittedBytes { get; init; }
}

public class Info
{
    public ProcessorInfo ProcessorInfo { get; init; }
    public GCMemoryInfo GCMemoryInfo { get; init; }
    public MemoryInfo MemoryInfo { get; init; }
}