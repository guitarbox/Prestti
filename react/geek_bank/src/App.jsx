import React, {Fragment, useState, useRef } from "react";
import BlockUI from "./BlockUI/BlockUI";

export function App(){
    const numero1 = useRef();
    const numero2 = useRef();
    const nombreUsuario = useRef();
    const resultado = useRef();

    const [state, setState] = useState({ blocking: false });
        
    const handleTodoAdd = () => {        
        if(numero1.current.value <= 0 || numero2.current.value <= 0) { alert('Por favor ingrese números mayor que 0'); }
        else{
            setState({ blocking: true });
            fetch('http://thankful-001-site4.itempurl.com/api/GeekBank', {
                method: 'POST', 
                mode: 'cors',                
                credentials: 'same-origin',
                headers: {
                    'Content-Type': 'application/json'
                },
                redirect: 'follow',
                referrerPolicy: 'no-referrer',
                body: JSON.stringify({ numero1: numero1.current.value, numero2: numero2.current.value, usuario: nombreUsuario.current.value, ipOrigen: 'reactUserIp' })
            })
            .then(response => {                
                return response.json();
            })
            .then(response => {                
                //console.log(response);
                resultado.current.value = response.suma;
                document.getElementById('existeEnFibo').innerHTML = `El resultado ${(response.existeEnFibo ? 'sí' : 'no')} está presente en los primeros 100 números de la serie fibonacci`;
                setState({ blocking: false });
            })
            .catch(response => console.error(response));            
        }

    }
    return(
    <Fragment>
        <h3>El Banco de los Geeks</h3>
        <h4>Por favor ingrese su nombre</h4>
        <input ref={nombreUsuario} type="text" placeholder="Nombre"/>
        <h4>Por favor ingrese 2 números mayores que 0 para sumarlos</h4>
        <input ref={numero1} type="number" placeholder="Número 1"/><br/>
        <input ref={numero2} type="number" placeholder="Número 2"/><br/>
        <button onClick={handleTodoAdd}>➕</button>
        <br/>
        <input ref={resultado} type="number" placeholder="Resultado"/>
        <br/>
        <label id="existeEnFibo"></label>
        {/* <button onClick={handleClearAll}>🗑️</button>         */}
        <BlockUI blocking={state.blocking} />
    </Fragment>
    );
};