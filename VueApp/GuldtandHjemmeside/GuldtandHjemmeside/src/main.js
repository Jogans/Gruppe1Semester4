import Vue from 'vue';
import App from './App.vue';
import VueRouter from 'vue-router';
import routes from './routes';
import axios from 'axios'

Vue.prototype.$http = axios;
Vue.config.productionTip = true;
Vue.use(VueRouter);


const router = new VueRouter({ routes });

new Vue({
    router,
    render: h => h(App)

}).$mount('#app');
