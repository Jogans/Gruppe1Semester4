import Vue from 'vue';
import App from './App.vue';
import VueRouter from 'vue-router';
import VueResource from 'vue-resource'
import routes from './routes';

Vue.config.productionTip = true;
Vue.use(VueResource);
Vue.use(VueRouter);

const router = new VueRouter({ routes });

new Vue({
    router,
    render: h => h(App)

}).$mount('#app');
