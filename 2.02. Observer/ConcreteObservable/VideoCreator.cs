using _02._Observer.ObservableInterface;
using _02._Observer.ObserverInterface;

namespace _02._Observer.ConcreteObservable;

public class VideoCreator : IObservable
{
    public string ChannelName { get; private set; } = string.Empty;
    public HashSet<IObserver> Viewers { get; private set; } = new HashSet<IObserver>();
    public List<VideoInfo> Videos { get; private set; } = new List<VideoInfo>();

    public VideoCreator(string channelName)
    {
        ChannelName = channelName;
    }

    public void AddObserver(IObserver viewer)
    {
		Viewers.Add(viewer);
    }

    public void RemoveObserver(IObserver viewer)
    {
		Viewers.Remove(viewer);
    }

    public void NotifyObservers(object obj)
    {
        foreach (IObserver viewer in Viewers)
			viewer.Update(obj);
    }

    public void UploadVideo(string name, string description, double duration)
    {
        VideoInfo videoInfo = new VideoInfo(ChannelName, name, description, duration, DateTime.Now);
		Videos.Add(videoInfo);
        NotifyObservers(videoInfo);
	}
}
