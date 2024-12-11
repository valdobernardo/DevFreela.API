namespace DevFreela.Application.Models
{
    public class ResultViewModel
    {
        // Construtor que recebe valores para sucesso (isSuccess) e mensagem (message)
        public ResultViewModel(bool isSuccess = true, string message = "")
        {
            IsSuccess = isSuccess; // Define se a operação foi bem-sucedida
            Message = message; // Define uma mensagem associada ao resultado
        }

        public bool IsSuccess { get; private set; } // Indica se a operação foi bem-sucedida
        public string Message { get; private set; } // Mensagem adicional (pode ser de erro ou sucesso)

        // Método estático para indicar sucesso sem mensagem
        public static ResultViewModel Success()
           => new(); // Cria um novo objeto ResultViewModel com sucesso

        // Método estático para indicar erro com uma mensagem
        public static ResultViewModel Error(string message)
            => new(false, message); // Cria um novo objeto ResultViewModel com erro
    }

    public class ResultViewModel<T> : ResultViewModel
    {
        // Construtor que recebe o dado (data), o sucesso (isSuccess) e a mensagem (message)
        public ResultViewModel(T? data, bool isSuccess = true, string message = "")
            : base(isSuccess, message)
        {
            Data = data; // Define o dado retornado pela operação
        }
        public T? Data { get; set; } // Propriedade que armazena o dado retornado pela operação


        // Método estático para sucesso com dados
        public static ResultViewModel<T> Success(T data)
            => new(data); // Cria um ResultViewModel com sucesso e dados


        // Método estático para erro com mensagem
        public static ResultViewModel<T> Error(string message)
            => new(default, false, message);  // Cria um ResultViewModel com erro e mensagem
    }
}
