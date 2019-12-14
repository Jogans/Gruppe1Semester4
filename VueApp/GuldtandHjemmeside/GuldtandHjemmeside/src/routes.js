import Home from './components/Home.vue';
import TopPage from './components/TopPage.vue';
import AllRecipes from './components/AllRecipes.vue';
import SearchBar from './components/SearchBar.vue';
import ProfilePage from './components/ProfilePage.vue';
import Kyllingikarry from './components/Recipes/Kyllingikarry.vue';
import BrndendeKrlighed from './components/Recipes/BrndendeKrlighed.vue';
import Hjemmelavetlasagne from './components/Recipes/Hjemmelavetlasagne.vue';
import Spaghettimedkdsovs from './components/Recipes/Spaghettimedkdsovs.vue';
import Pandekager from './components/Recipes/Pandekager.vue';
import Plsehorn from './components/Recipes/Plsehorn.vue';
import CreateUser from './components/CreateUser.vue';
import CreateRecipe from './components/CreateRecipe.vue';
import TestCalculator from './components/TestCalculator.vue';
import Typeahead from './components/Typeahead.vue';



const routes = [
    { path: '/', component: Home },
    { path: '/TopPage', component: TopPage },
    { path: '/AllRecipes', component: AllRecipes },
    { path: '/SearchBar', component: SearchBar },
    { path: '/ProfilePage', component: ProfilePage },
    { path: '/CreateUser', component: CreateUser },
    { path: '/CreateRecipe', component: CreateRecipe },
    { path: '/Recipe/Kyllingikarry', component: Kyllingikarry },
    { path: '/Recipe/BrndendeKrlighed', component: BrndendeKrlighed },
    { path: '/Recipe/Hjemmelavetlasagne', component: Hjemmelavetlasagne },
    { path: '/Recipe/Spaghettimedkdsovs', component: Spaghettimedkdsovs },
    { path: '/Recipe/Pandekager', component: Pandekager },
    { path: '/Recipe/Plsehorn', component: Plsehorn },
    { path: '/Typeahead', component: Typeahead },
    { path: '/TestCalculator', component: TestCalculator }

];

export default routes;

