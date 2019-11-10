import Home from './components/Home.vue';
import TopPage from './components/TopPage.vue';
import NewPage from './components/NewPage.vue';
import SUPage from './components/SUPage.vue';
import VegiPage from './components/VegiPage.vue';
import ClassicPage from './components/ClassicPage.vue';
import StorePage from './components/StorePage.vue';
import ProfilePage from './components/ProfilePage.vue';
import PizzaHomemade from './components/Recipes/PizzaHomemade.vue';
import CreateUser from './components/CreateUser.vue';
import CreateRecipe from './components/CreateRecipe.vue';



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
    { path: '/CreateRecipe', component: CreateRecipe },
    { path: '/Recepie/PizzaHomemade', component: PizzaHomemade }


];

export default routes;