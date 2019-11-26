import Home from './components/Home.vue';
import TopPage from './components/TopPage.vue';
import NewPage from './components/NewPage.vue';
import Searchsite from './components/Searchsite.vue';
import SUPage from './components/SUPage.vue';
import VegiPage from './components/VegiPage.vue';
import ClassicPage from './components/ClassicPage.vue';
import StorePage from './components/StorePage.vue';
import ProfilePage from './components/ProfilePage.vue';
import PizzaHomemade from './components/Recipes/PizzaHomemade.vue';
import ShowRecipe from './components/Recipes/ShowRecipe.vue';
import CreateUser from './components/CreateUser.vue';
import CreateRecipe from './components/CreateRecipe.vue';
import TestCalculator from './components/TestCalculator.vue';
import Typeahead from './components/Typeahead.vue';



const routes = [
    { path: '/', component: Home },
    { path: '/TopPage', component: TopPage },
    { path: '/NewPage', component: NewPage },
    { path: '/SUPage', component: SUPage },
    { path: '/Searchsite', component: Searchsite },
    { path: '/VegiPage', component: VegiPage },
    { path: '/ClassicPage', component: ClassicPage },
    { path: '/StorePage', component: StorePage },
    { path: '/ProfilePage', component: ProfilePage },
    { path: '/CreateUser', component: CreateUser },
    { path: '/CreateRecipe', component: CreateRecipe },
    { path: '/Recepie/PizzaHomemade', component: PizzaHomemade },
    { path: '/Recepie/ShowRecipe', component: ShowRecipe },
    { path: '/Typeahead', component: Typeahead },
    { path: '/TestCalculator', component: TestCalculator }



];

export default routes;