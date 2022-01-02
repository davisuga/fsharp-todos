module Todo
open Feliz

[<ReactComponent>]
let TodoItem(todo: Domain.Todo) =
    Html.div [
     prop.className "todo-item"
     prop.children [
          Html.div [
               prop.className "todo-item-title"
               prop.children [Html.text todo.title]
          ];
          Html.div [
               prop.className "todo-item-description"
               prop.children [Html.text todo.description]
          ]
     ]
    ]

[<ReactComponent>]
let TodoList(list: list<Domain.Todo>) =
     Html.div [
          prop.className "todos"
          prop.children (List.map TodoItem list)
     ]

