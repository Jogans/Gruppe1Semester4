import Home from './components/Home.vue';
import TopPage from './components/TopPage.vue';
import NewPage from './components/NewPage.vue';
import SUPage from './components/SUPage.vue';
import VegiPage from './components/VegiPage.vue';
import ClassicPage from './components/ClassicPage.vue';
import StorePage from './components/StorePage.vue';
import ProfilePage from './components/ProfilePage.vue';





const routes = [
    { path: '/', component: Home },
    { path: '/TopPage', component: TopPage },
    { path: '/NewPage', component: NewPage },
    { path: '/SUPage', component: SUPage },
    { path: '/VegiPage', component: VegiPage },
    { path: '/ClassicPage', component: ClassicPage },
    { path: '/StorePage', component: StorePage },
    { path: '/ProfilePage', component: ProfilePage }



];

export default routes;