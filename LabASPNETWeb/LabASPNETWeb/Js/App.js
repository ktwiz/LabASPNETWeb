import State from './State.js';

class App {
    constructor () {
        this._state = State.state;
    }

    render () {       
        const appState = State.getState();
        const {active_page} = appState;       
        const pageClass = appState.pages[active_page];

        return pageClass.renderPage();
    }
}


export default App;