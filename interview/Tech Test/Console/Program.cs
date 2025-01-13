using Spectre.Console;

// Pantalla inicial
AnsiConsole.Markup("[bold yellow]¡Bienvenido a Tech Test![/]\n");
AnsiConsole.Markup("Selecciona una opción para comenzar:\n");

while (true)
{
    // Menú principal
    var opcion = AnsiConsole.Prompt(
        new SelectionPrompt<string>()
            .Title("[bold green]Elige un ejercicio:[/]")
            .PageSize(10)
            .AddChoices(
            [
                "Arrays",
                "Listas Enlazadas",
                "Pilas y Colas",
                "Árboles Binarios",
                "Grafos",
                "Salir"
            ]));

    if (opcion == "Salir")
    {
        AnsiConsole.Markup("[bold red]¡Hasta luego, programador estrella![/]\n");
        break;
    }

    // Mostrar el submenú correspondiente
    MostrarSubmenu(opcion);
}

// Método para mostrar submenús
void MostrarSubmenu(string categoria)
{
    AnsiConsole.Markup($"\n[bold cyan]Ejercicios en la categoría: {categoria}[/]\n");
    // Aquí podemos añadir lógica específica para cada categoría
    AnsiConsole.Markup("[italic]¡Aún no hay ejercicios definidos aquí![/]\n\n");
}
