<template>
    <keep-alive>
        <div class="sidebar">
            <transition name="slide">
                <div v-if="isPanelOpen" class="sidebar-panel">

                    <div class="butikkerValg">
                        <input type="checkbox" id="cb1" />
                        <label for="cb1"><img src="@/assets/Pics/Netto.png" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb2" />
                        <label for="cb2"><img src="@/assets/Pics/Foetex.png" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb3" />
                        <label for="cb3"><img src="@/assets/Pics/Rema.jpg" /></label>
                        <br style="clear:both" />
                        <input type="checkbox" id="cb4" />
                        <label for="cb4"><img src="@/assets/Pics/Fakta.png" /></label>
                    </div>

                    <br style="clear:both" />

                    <br style="clear:both" />

                    <div class="antalPersoner">
                        <select>
                            <option value="0">Antal Personer:</option>
                            <option value="1">1 Person</option>
                            <option value="2">2 Person</option>
                            <option value="3">3 Person</option>
                            <option value="4">4 Person</option>
                            <option value="5">5 Person</option>
                            <option value="6">6 Person</option>
                            <option value="7">7 Person</option>
                            <option value="8">8 Person</option>
                            <option value="9">9 Person</option>
                            <option value="10">10 Person</option>

                        </select>
                    </div>

                    <div class="CheckboxDishes">
                        <br style="clear:both" />
                        <input class="cbox" type="checkbox" id="dish1">
                        <label for="dish1">Pasta</label>
                        <br style="clear:both" />
                        <input class="cbox" type="checkbox" id="dish2">
                        <label for="dish2">Ris</label>
                        <br style="clear:both" />
                        <input class="cbox" type="checkbox" id="dish3">
                        <label for="dish3">Oksek&#248;d</label>
                        <br style="clear:both" />
                        <input class="cbox" type="checkbox" id="dish4">
                        <label for="dish4">Svinek&#248;d</label>
                    </div>

                </div>
            </transition>

        </div>
    </keep-alive>
</template>
<script>

    export default {
        data: () => ({
            isPanelOpen: true
        }),
        methods: {
            closeSidebarPanel() {
                this.isPanelOpen = false
            }
        }
    }
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

    .butikkerValg {
        display: inline-block;
        width: 75px;
        height: 75px;
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

    .sidebar-backdrop {
        background-color: rgba(0,0,0,.5);
        width: 100vw;
        height: 100vh;
        position: fixed;
        top: 0;
        left: 0;
        cursor: pointer;
    }

    .sidebar-panel {
        overflow-y: auto;
        background-color: #130f40;
        position: fixed;
        left: 0;
        top: 0;
        height: 100vh;
        z-index: 999;
        padding: 3rem 20px 2rem 20px;
        width: 200px;
    }

    ul {
        list-style-type: none;
        float: right;
    }

    li {
        display: inline-block;
    }

    input[type="checkbox"][id^="cb"] {
        display: block;
    }

    label {
        border: 1px solid #fff;
        padding: 6px;
        display: block;
        position: relative;
        margin: 2px;
        cursor: pointer;
        margin-right: 10%;
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
            transition-duration: 0.2s;
            transform-origin: 50% 50%;
        }

    :checked + label {
        border-color: #ddd;
    }

        :checked + label:before [id^="cb"] {
            content: "\2713";
            background-color: grey;
            transform: scale(0.6);
        }

        :checked + label img {
            transform: scale(0.7);
            box-shadow: 0 0 2px #333;
            z-index: -1;
        }
</style>
