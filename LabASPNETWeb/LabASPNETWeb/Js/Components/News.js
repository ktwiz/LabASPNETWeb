import State from '../State.js';

class News {

    constructor(){
        
    }

    renderDetail(news_id){        
        let news_item = State.state.newss[news_id];

        return `
        <div class="col-lg-8">
            <h1 class="my-4">
                ${news_item.title}
            </h1>
            <p class="lead">
                by
                <a href="#">[${news.usr_create}] - ${news_item.username}</a>
            </p>
            <hr>
            <!-- Date/Time -->
            <p>Posted on ${news_item.createdt}</p>
            <hr>
            <!-- Post Content -->
            ${news_item.content}
        </div>
        `;
    }

    renderNews(news){
        return `
            <div class="card mb-4">    
                <div class="card-body">
                    <h2 class="card-title">${news.title}</h2>
                    <p class="card-text">${news.shortdesc}</p>
                    <a href="#" class="btn btn-primary">Read More &rarr;</a>
                </div>
                <div class="card-footer text-muted">
                    Posted on ${news.createdt} by
                    <a href="#">[${news.usr_create}] - ${news.username}</a>
                </div>
            </div>
            `;
    }

    renderListNews(newss){
        return newss.map((n) => {
            return this.renderNews(n);
        }).join("");
    }

    render(){
        return this.renderListNews(State.state.newss);
    }
}

export default News