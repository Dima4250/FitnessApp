using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessApp
{
    // Интерфейс наблюдателя
    public interface IObserver
    {
        void Update(string message);
    }

    // Интерфейс наблюдаемого объекта
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }

    // Интерфейс сервиса уведомлений
    public interface INotificationService
    {
        Task SendNotificationAsync(string message);
    }
}
