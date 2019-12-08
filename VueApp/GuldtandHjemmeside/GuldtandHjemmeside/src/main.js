import Vue from 'vue';
import Vuex from 'vuex';
import App from './App.vue';
import VueRouter from 'vue-router';
import routes from './routes';
import axios from 'axios';
import store from './store';

Vue.prototype.$http = axios;
Vue.config.productionTip = true;
Vue.use(Vuex);
Vue.use(VueRouter);
axios.default.withCredentials = true;

const router = new VueRouter({ routes });

new Vue({
    router,
    store,
    render: h => h(App)
}).$mount('#app');
