module Home
open Feliz

open Todo

let initialTodoList = []

[<ReactComponent>]
let Home() =
     let (todos, setTodos) = React.useState<list<Domain.Todo>>([])
     let (title, setTitle) = React.useState("")
     let (description, setDescription) = React.useState("")

     let onSubmit _ = 
          setTodos(list.Cons( {title = title; description = description}, todos))
          setTitle("")
          setDescription("")

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
                    ];
                    Html.button [
                         prop.className "submit"
                         prop.onClick onSubmit
                         prop.text "Add todo"
                    ]
               ]
          ];
          TodoList(todos); 
          ]]