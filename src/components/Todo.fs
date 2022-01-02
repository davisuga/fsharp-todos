module Todo
open Feliz

[<ReactComponent>]
let TodoList(list: list<Domain.Todo>) =
     Html.div "Todos: "

[<ReactComponent>]
let TodoItem() =
    Html.div "im an item"