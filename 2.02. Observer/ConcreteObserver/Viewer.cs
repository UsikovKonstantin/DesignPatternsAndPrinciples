using _02._Observer.ObservableInterface;
using _02._Observer.ObserverInterface;

namespace _02._Observer.ConcreteObserver;

public class Viewer : IObserver
{
    public HashSet<IObservable> VideoCreators { get; private set; } = new HashSet<IObservable>();
    public string Name { get; private set; }

    public Viewer(string name)
    {
        Name = name;
    }

    public void Subscribe(IObservable videoCreator)
    {
		videoCreator.AddObserver(this);
        VideoCreators.Add(videoCreator);
    }

    public void Unsubscribe(IObservable videoCreator)
    {
		videoCreator.RemoveObserver(this);
        VideoCreators.Remove(videoCreator);
    }

    public void Update(object obj)
    {
        if (obj is VideoInfo videoInfo)
			Console.WriteLine($"Зритель {Name} получил уведомление о выходе видео \"{videoInfo.Name}\" на канале {videoInfo.ChannelName}.");
    }
}
