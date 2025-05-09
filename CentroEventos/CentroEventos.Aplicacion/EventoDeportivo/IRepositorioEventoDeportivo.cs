namespace CentroEventos.Aplicacion.EventoDeportivo;

public interface IRepositorioEventoDeportivo
{
    void AgregarEventoDeportivo(EventoDeportivo evento);
    void EliminarEventoDeportivo(int id);
    void ModificarEventoDeportivo(int id);
    List<EventoDeportivo> ListarEventoDeportivo();
}
