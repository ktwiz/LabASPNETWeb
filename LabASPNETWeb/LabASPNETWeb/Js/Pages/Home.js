import News from "../Components/News.js";
import Nav from "../Components/Nav.js";
import Login from "../Components/MenuLogin.js"

const renderPage = () => {
    const title_page = "Home Page";
    const newss = new News();
    return `
    <div class="container">
        ${Nav.renderNavBar()}
        <div class="row">
            <!-- Blog Entries Column -->
            <div class="col-md-8">

                <h1 class="my-4">
                    ${title_page}
                </h1>

                ${newss.render()}

            </div>

            <!-- Sidebar Widgets Column -->
            <div class="col-md-4">
                ${Login.renderLeftMenu()}
            </div>
            

        </div>
        <!-- /.row -->
    </div>        
    `;
}

export default {
    renderPage,
};