import Home from './components/Home.vue';
import TopPage from './components/TopPage.vue';
import NewPage from './components/NewPage.vue';
import SUPage from './components/SUPage.vue';
import VegiPage from './components/VegiPage.vue';
import ClassicPage from './components/ClassicPage.vue';
import StorePage from './components/StorePage.vue';
import ProfilePage from './components/ProfilePage.vue';
import HomemadePizza from './components/Recepies/HomemadePizza.vue';
import HomemadePizzaTest from './components/HomemadePizzaTest.vue';
import CreateUser from './components/CreateUser.vue';


const routes = [
    { path: '/', component: Home },
    { path: '/TopPage', component: TopPage },
    { path: '/NewPage', component: NewPage },
    { path: '/SUPage', component: SUPage },
    { path: '/VegiPage', component: VegiPage },
    { path: '/ClassicPage', component: ClassicPage },
    { path: '/StorePage', component: StorePage },
    { path: '/ProfilePage', component: ProfilePage },
    { path: '/CreateUser', component: CreateUser },
    { path: '/Recepie/HomemadePizza', components: HomemadePizza },
    { path: '/HomemadePizzaTest', components: HomemadePizzaTest }


];

export default routes;