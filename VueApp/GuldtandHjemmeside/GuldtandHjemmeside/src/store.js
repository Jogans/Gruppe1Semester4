import Vue from 'vue';
import Vuex from 'vuex';

Vue.use(Vuex);

export default new Vuex.Store({
    state: {
        stores: ""
    },
    mutations: {
        setStores(state, payload) {
            state.stores = payload;
        }
    },
    getter: {
        doneTodos: state => {
            return state.stores;
        }
    }
})