namespace EnumAula.Entities.Enums
{
    enum OrderStatus : int // Enum: conjunto de constantes relacionadas, exemplo abaixo: Status do pedido
    {                      // Útil para organizar e categorizar valores relacionados. 
                           // Cada valor enum é associado a um int, mas pode ser acessado através dos nomes
        PedingPayment = 0,
        Processing = 1,
        Shipped = 2, // Enviado
        Delivered = 3 // Entregue
    }
}
