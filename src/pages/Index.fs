module Routes

open Home
open Feliz.Router
open Feliz

[<ReactComponent>]
let Router () =
    let (currentUrl, updateUrl) = React.useState (Router.currentUrl ())

    React.router [ router.onUrlChanged updateUrl
                   router.children [ match currentUrl with
                                     | [] -> Home()
                                     | otherwise -> Html.h1 "Not found" ] ]
