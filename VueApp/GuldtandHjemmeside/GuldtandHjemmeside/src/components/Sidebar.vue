<template>
    <keep-alive>
        <div class="sidebar">
            <transition name="slide">
                <div v-if="isPanelOpen" class="sidebar-panel">
                    <p>V&aelig;lg hvilke butikker du vil se tilbud fra:</p>
                    <div class="butikkerValg">
                        <input type="checkbox" id="cb1" v-model="checkedNetto" />
                        <label for="cb1"><img src="@/assets/Pics/Netto.png" alt="Netto" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb2" v-model="checkedFoetex" />
                        <label for="cb2"><img src="@/assets/Pics/Foetex.png" alt="Foetex" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb3" v-model="checkedRema" />
                        <label for="cb3"><img src="@/assets/Pics/Rema.jpg" alt="Rema" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb4" v-model="checkedFakta" />
                        <label for="cb4"><img src="@/assets/Pics/Fakta.png" alt="Fakta" /></label>
                    </div>
                    <div class="butikkerValg">
                        <input type="checkbox" id="cb5" v-model="checkedBilka" />
                        <label for="cb5"><img src="@/assets/Pics/Bilka.jpg" alt="Bilka" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb6" v-model="checkedAldi" />
                        <label for="cb6"><img src="@/assets/Pics/Aldi.png" alt="Aldi" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb7" v-model="checkedKvickly" />
                        <label for="cb7"><img src="@/assets/Pics/Kvickly.png" alt="Kvickly" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb8" v-model="checkedLidl" />
                        <label for="cb8"><img src="@/assets/Pics/Lidl.png" alt="Lidl" /></label>
                    </div>

                    <button class="test_btn" @click="stores">Gem butiksvalg</button>

                    <br style="clear:both" />

                    <br style="clear:both" />

                    <div class="antalPersoner">
                        <select class="dropDown">
                            <option value="0">Antal Personer:</option>
                            <option value="1">1 Person</option>
                            <option value="2">2 Personer</option>
                            <option value="3">3 Personer</option>
                            <option value="4">4 Personer</option>
                            <option value="5">5 Personer</option>
                            <option value="6">6 Personer</option>
                            <option value="7">7 Personer</option>
                            <option value="8">8 Personer</option>
                            <option value="9">9 Personer</option>
                            <option value="10">10 Personer</option>

                        </select>
                    </div>
                    <br style="clear:both" />

                    <div class="CheckboxDishes">
                        <p>Hvilke retter &oslash;nsker du?</p>

                        <ul class="dishes-li">
                            <li>
                                <input class="cbox" type="checkbox" id="dish1">
                                <label for="dish1">Pasta</label>
                            </li>
                            <li>
                                <input class="cbox" type="checkbox" id="dish2">
                                <label for="dish2">Ris</label>
                            </li>
                            <li>
                                <input class="cbox" type="checkbox" id="dish3">
                                <label for="dish3">Oksek&#248;d</label>
                            </li>
                            <li>
                                <input class="cbox" type="checkbox" id="dish4">
                                <label for="dish4">Svinek&#248;d</label>
                            </li>
                        </ul>




                    </div>
                    <br />
                    <span v-html="info">{{info}}</span>
                </div>
            </transition>

        </div>
    </keep-alive>
</template>
<script>

    export default {
        data: function () {
            return {
                isPanelOpen: true,
                info: null,
                checkedString: "",
                checkedNetto: true,
                checkedFoetex: true,
                checkedRema: true,
                checkedFakta: true,
                checkedBilka: true,
                checkedAldi: true,
                checkedKvickly: true,
                checkedLidl: true,
            }
        },
        methods: {
            setStores() {
                this.$store.commit('setStores', { amount: this.createStoreString() })
            },
            closeSidebarPanel() {
                this.isPanelOpen = false
            },
            createStoreString() {
                this.checkedString = "";
                if (this.checkedNetto != true) {
                    this.checkedString += "Netto;";
                }
                if (this.checkedFoetex != true) {
                    this.checkedString += "Foetex;";
                }
                if (this.checkedRema != true) {
                    this.checkedString += "Rema;";
                }
                if (this.checkedFakta != true) {
                    this.checkedString += "Fakta;";
                }
                if (this.checkedBilka != true) {
                    this.checkedString += "Bilka;";
                }
                if (this.checkedAldi != true) {
                    this.checkedString += "Aldi;";
                }
                if (this.checkedKvickly != true) {
                    this.checkedString += "Kvickly;";
                }
                if (this.checkedLidl != true) {
                    this.checkedString += "Lidl;";
                }
                return this.checkedString;
            },
            stores() {
                this.createStoreString();
                this.$root.$emit('clickedSaveStores', this.checkedString)
            }
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
    span {
        color: white;
    }

    .butikkerValg {
        display: inline-block;
        width: 65px;
        padding-left: 15px;
        position: relative;
    }

    .CheckboxDishes {
        display: block;
        width: 100px;
        color: white;
    }

    input[type='checkbox'] {
        float: left;
        width: 10px;
        position: relative;
    }

    .slide-enter-active,
    .slide-leave-active {
        transition: transform 0.2s ease;
    }

    .slide-enter,
    .slide-leave-to {
        transform: translateX(-100%);
        transition: all 150ms ease-in 0s
    }

    /*.sidebar-backdrop {
        background-color: rgba(0,0,0,.5);
        width: 100vw;
        height: 100vh;
        position: fixed;
        top: 0;
        left: 0;
        cursor: pointer;
    }*/

    .sidebar-panel {
        overflow-y: auto;
        /*background-color: #130f40;*/
        background-color: var(--accent-color);
        position: fixed;
        float: right;
        left: 0;
        top: 0;
        height: 100%;
        z-index: 1;
        padding: 30px 20px 20px 20px;
        width: 175px;
        color: lightgray;
        font-size:14px;
    }


 

    input[type="checkbox"][id^="cb"] {
        display: block;
    }

    label {
        display: block;
        position: relative;
        margin: 2px;
        cursor: pointer;
        /*margin-right: 10%;*/
    }

        label:before {
            background-color: white;
            color: white;
            content: " ";
            display: block;
            border-radius: 50%;
            border: 1px solid grey;
            position: absolute;
            top: -5px;
            left: -5px;
            width: 25px;
            height: 25px;
            text-align: center;
            line-height: 28px;
            transition-duration: 0.4s;
            transform: scale(0);
            float: right;
        }

        label img {
            height: 10%;
            width: 45px;
            transform:scale(0.6);
            transition-duration: 0.2s;
            transform-origin: 50% 50%;
        }

    :checked + label {
        border-color: #ddd;
    }

        :checked + label:before [id^="cb"] {
            content: "\2713";
            background-color: grey;
            transform: scale(0.1);
        }

        :checked + label img {
            transform: scale(1);
            box-shadow: 0 0 2px #333;
            z-index: -1;
            box-shadow:none;

        }


    .test_btn {
        width:125px;
        padding:6px 10px;
        margin: 15px 25px;
    }

    .test_btn:hover {
    }

    .dropDown{
        width:100%;
        padding:5px;
        background-color:#ececec
    }

    .CheckboxDishes {
        width:100%;
        color: lightgray;
        font-size:14px;
        
    }

    .dishes-li {
        display:block;
        position:relative;
        left:0px;
        width:80%;
        padding-left:0px;
        list-style-type:none;
    }

    .dishes-li li {
        margin-bottom:10px;
    }


    /*.CheckboxDishes label {
        padding:5px;
    }

    .CheckboxDishes .cbox {
        margin-top:8px;
    }*/
</style>
