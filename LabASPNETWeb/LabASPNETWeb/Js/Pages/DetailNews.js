import News from "../Components/News.js"

class DetailNewsPage{
    constructor(){
        this._news = new News();        
    }

    render(news_id){
        return `<h1>News Detail</h1>
        <br />
        ${this._news.renderDetail(news_id)}
        `;
    };
}

export default DetailNewsPage;