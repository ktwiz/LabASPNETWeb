import State from './State.js';

class App {
    constructor () {
        this._state = State.state;       
    }
    
    render () {       
        return `Hello World ! Is Logged is ${this._state['is_loggedin']}`;
    }
}


export default App;