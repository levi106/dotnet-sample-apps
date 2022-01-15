namespace BackendService6.Models;

public class ProcessorInfo
{
    public int ProcessorCount { get; init; } = 0;
}

public class MemoryInfo
{
    public long TotalAllocatedBytes { get; init; } = 0;
    public long TotalMemory { get; init; } = 0;
    public int Gen0CollectionCount { get; init; } = 0;
    public int Gen1CollectionCount { get; init; } = 0;
    public int Gen2CollectionCount { get; init; } = 0;
}

public class MyGCMemoryInfo
{
    public MyGCMemoryInfo()
    { }

    public MyGCMemoryInfo(System.GCMemoryInfo info)
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

    public bool Compacted { get; init; } = false;
    public bool Concurrent { get; init; } = false;
    public long FinalizationPendingCount { get; init; } = 0;
    public long FragmentedBytes { get; init; } = 0;
    public int Generation { get; init; } = 0;
    public long HeapSizeBytes { get; init; } = 0;
    public long HighMemoryLoadThresholdBytes { get; init; } = 0;
    public long Index { get; init; } = 0;
    public long MemoryLoadBytes { get; init; } = 0;
    public double PauseTimePercentage { get; init; } = 0;
    public long PinnedObjectsCount { get; init; } = 0;
    public long PromotedBytes { get; init; } = 0;
    public long TotalAvailableMemoryBytes { get; init; } = 0;
    public long TotalCommittedBytes { get; init; } = 0;
}

public class Info
{
    public ProcessorInfo ProcessorInfo { get; init; } = null!;
    public MyGCMemoryInfo MyGCMemoryInfo { get; init; } = null!;
    public MemoryInfo MemoryInfo { get; init; } = null!;
}