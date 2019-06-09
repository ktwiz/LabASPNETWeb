let state = 
{
    is_loggedin: false,
    pages: ["Home", "About"],
}

const historyState = [{ ...state, _time: new Date() }];

const events = {};

const subcribe = (eventName, callback) => {
    if (!events.hasOwnProperty(eventName)) events[eventName] = [];
    events[eventName].push(callback);
};

const publish = (eventName, data) => {
    if (!events.hasOwnProperty(eventName)) return;
    events[eventName].map(callback => {
        callback(data);
    });
};

const getState = () => state;

const setState = newState => {
    state = newState;
    historyState.push({ ...newState, _time: new Date() });
    console.clear();
    console.table(historyState);
    publish("stateChanged", newState);
};

export default {
    state,
    getState,
    setState,
    subcribe
};