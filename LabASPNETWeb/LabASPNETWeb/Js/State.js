import Home from './Pages/Home.js';
import DetailNews from './Pages/DetailNews.js';

let state = 
{
    is_loggedin: false,
    active_page: "home",
    pages: 
        {
            'home' : Home,
            'detailnews' : DetailNews
        }
    ,
    newss: [
        {title: "1", shortdesc: "acb", createdt: "01/01/2019", usr_create: "TuanDH", username : "Duong Hong Tuan", content: "Noi dung 1" },
        {title: "2", shortdesc: "acb2", createdt: "02/01/2019", usr_create: "TuanDH", username : "Duong Hong Tuan", content: "Noi dung 2" },
    ]
};

const titlepage = 'Tuan Website';

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
    subcribe,
    titlepage
};