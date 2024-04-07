namespace _02._Observer;

public class VideoInfo
{
	public string ChannelName { get; private set; } = string.Empty;
	public string Name { get; private set; } = string.Empty;
	public string Description { get; private set; } = string.Empty;
	public double Duration { get; private set; }
	public DateTime ReleaseDate { get; private set; }

    public VideoInfo(string channelName, string name, string description, double duration, DateTime releaseDate)
    {
		ChannelName = channelName;
		Name = name;
        Description = description;
        Duration = duration;
        ReleaseDate = releaseDate;
    }
}
