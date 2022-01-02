module Home
open Feliz

open Todo

let initialTodoList = []

[<ReactComponent>]
let Home() =
     let (todos, setTodos) = React.useState<list<Domain.Todo>>([])
     let (title, setTitle) = React.useState("")
     let (description, setDescription) = React.useState("")


     Html.div [prop.children [
          Html.div[
               prop.className "form";
               prop.children [
                    Html.input [
                         prop.className "title"
                         prop.value title // string
                         prop.onChange setTitle // (string -> unit)
                         prop.placeholder "What to do..."
                    ];
                    Html.textarea [
                         prop.className "description"
                         prop.value description // string
                         prop.onChange setDescription // (string -> unit)
                    ]
               ]
          ];
          TodoList(todos); 
          ]]