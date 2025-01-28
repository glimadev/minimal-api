using Flunt.Notifications;
using Flunt.Validations;
using MiniTodo.Model;

namespace MiniTodo.ViewModel;

public class CreateTodoViewModel : Notifiable<Notification>
{
    public string Title { get; set; } = string.Empty;

    public Todo MapTo()
    {
        AddNotifications(new Contract<Notification>()
            .Requires()
            .IsNotNull(Title, "Informe o título da tarefa")
            .IsGreaterThan(Title, 5, "O título deve conter mais de 5 caracteres"));

        return new Todo { Title = Title };
    }
}
