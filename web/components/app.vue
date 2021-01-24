<template>
    <div class="app">
        <div class="app-title">
            <div class="app-title-name">
                <h2 style="margin-right: auto;">Vscode Snippets</h2>
                <!-- backup -->
                <svg
                    @click="app.backup"
                    t="1589352670488"
                    class="icon"
                    viewBox="0 0 1024 1024"
                    version="1.1"
                    xmlns="http://www.w3.org/2000/svg"
                    p-id="3036"
                    width="32"
                    height="32"
                >
                    <path
                        d="M1022.955204 556.24776c0 100.19191-81.516572 181.698249-181.718715 181.698249l-185.637977 0c-11.2973 0-20.466124-9.168824-20.466124-20.466124 0-11.307533 9.168824-20.466124 20.466124-20.466124l185.637977 0c77.628008 0 140.786467-63.148226 140.786467-140.766001 0-77.423347-62.841234-140.448776-140.203182-140.766001-0.419556 0.030699-0.828878 0.051165-1.248434 0.061398-5.935176 0.153496-11.665691-2.302439-15.666818-6.702656-4.001127-4.41045-5.884011-10.345626-5.157463-16.250102 1.330298-10.806113 1.944282-19.760043 1.944282-28.192086 0-60.763922-23.658839-117.874641-66.617234-160.833035-42.968627-42.958394-100.089579-66.617234-160.843268-66.617234-47.368844 0-92.742241 14.449084-131.208321 41.781592-37.616736 26.738991-65.952084 63.700811-81.925894 106.884332-2.425236 6.54916-8.012488 11.399631-14.827707 12.893658-6.815219 1.483794-13.927197-0.603751-18.859533-5.536087-19.289322-19.340487-44.943608-29.982872-72.245418-29.982872-56.322773 0-102.146425 45.813419-102.146425 102.125959 0 0.317225 0.040932 0.982374 0.092098 1.627057 0.061398 0.920976 0.122797 1.831718 0.153496 2.762927 0.337691 9.465582-5.863545 17.928325-15.001669 20.455891-32.356942 8.943696-61.541635 28.550243-82.181721 55.217602-21.305235 27.516704-32.571836 60.508096-32.571836 95.41307 0 86.244246 70.188572 156.422585 156.443052 156.422585l169.981393 0c11.2973 0 20.466124 9.15859 20.466124 20.466124 0 11.2973-9.168824 20.466124-20.466124 20.466124l-169.981393 0c-108.828614 0-197.3753-88.536452-197.3753-197.354833 0-44.053332 14.223956-85.712127 41.126676-120.473839 22.809495-29.450752 53.897537-52.086285 88.710414-64.816215 5.065366-74.322729 67.149353-133.2447 142.751215-133.2447 28.386514 0 55.504128 8.217149 78.651314 23.52581 19.657712-39.868009 48.842405-74.169233 85.497233-100.212376 45.434795-32.295544 99.004875-49.354058 154.918325-49.354058 71.692832 0 139.087778 27.915793 189.782368 78.600149 50.694589 50.694589 78.610382 118.089535 78.610382 189.782368 0 3.704368-0.102331 7.470135-0.296759 11.368932C952.633602 386.245901 1022.955204 463.188294 1022.955204 556.24776zM629.258611 589.106122c-3.990894 3.990894-9.230222 5.996574-14.46955 5.996574s-10.478655-2.00568-14.46955-5.996574l-67.087954-67.077721 0 358.689289c0 11.307533-9.15859 20.466124-20.466124 20.466124-11.307533 0-20.466124-9.15859-20.466124-20.466124l0-358.689289-67.087954 67.077721c-7.992021 7.992021-20.947078 7.992021-28.939099 0s-7.992021-20.957311 0-28.949332l102.023628-102.013395c7.992021-7.992021 20.947078-7.992021 28.939099 0l102.023628 102.013395C637.250632 568.148811 637.250632 581.114101 629.258611 589.106122z"
                        p-id="3037"
                    />
                </svg>
                <!-- restore -->
                <svg
                    @click="app.restore"
                    style="margin:10px;"
                    t="1589352753535"
                    class="icon"
                    viewBox="0 0 1024 1024"
                    version="1.1"
                    xmlns="http://www.w3.org/2000/svg"
                    p-id="1338"
                    width="32"
                    height="32"
                >
                    <path
                        d="M1022.955204 522.570753c0 100.19191-81.516572 181.698249-181.718715 181.698249l-185.637977 0c-11.2973 0-20.466124-9.168824-20.466124-20.466124 0-11.307533 9.168824-20.466124 20.466124-20.466124l185.637977 0c77.628008 0 140.786467-63.148226 140.786467-140.766001 0-77.423347-62.841234-140.448776-140.203182-140.766001-0.419556 0.030699-0.818645 0.051165-1.217734 0.061398-5.945409 0.143263-11.686157-2.292206-15.687284-6.702656-4.001127-4.400217-5.894244-10.335393-5.167696-16.250102 1.330298-10.806113 1.944282-19.760043 1.944282-28.192086 0-60.763922-23.658839-117.884874-66.617234-160.833035-42.968627-42.968627-100.089579-66.617234-160.843268-66.617234-47.368844 0-92.742241 14.449084-131.208321 41.781592-37.616736 26.738991-65.952084 63.700811-81.925894 106.884332-2.425236 6.538927-8.012488 11.399631-14.827707 12.893658-6.815219 1.483794-13.927197-0.603751-18.859533-5.54632-19.289322-19.330254-44.943608-29.972639-72.245418-29.972639-56.322773 0-102.146425 45.813419-102.146425 102.125959 0 0.317225 0.040932 0.982374 0.092098 1.627057 0.061398 0.920976 0.122797 1.831718 0.153496 2.762927 0.337691 9.465582-5.863545 17.928325-15.001669 20.455891-32.356942 8.933463-61.541635 28.550243-82.181721 55.217602-21.305235 27.516704-32.571836 60.508096-32.571836 95.41307 0 86.244246 70.188572 156.422585 156.443052 156.422585l169.981393 0c11.2973 0 20.466124 9.15859 20.466124 20.466124 0 11.2973-9.168824 20.466124-20.466124 20.466124l-169.981393 0c-108.828614 0-197.3753-88.536452-197.3753-197.354833 0-44.053332 14.223956-85.712127 41.126676-120.473839 22.809495-29.460985 53.897537-52.086285 88.710414-64.816215 5.065366-74.322729 67.149353-133.2447 142.751215-133.2447 28.386514 0 55.504128 8.217149 78.651314 23.52581 19.657712-39.868009 48.842405-74.169233 85.497233-100.212376 45.434795-32.295544 99.004875-49.354058 154.918325-49.354058 71.692832 0 139.087778 27.915793 189.782368 78.600149 50.694589 50.694589 78.610382 118.089535 78.610382 189.782368 0 3.704368-0.102331 7.470135-0.296759 11.368932C952.633602 352.568894 1022.955204 429.511287 1022.955204 522.570753zM629.258611 820.711014l-102.023628 102.013395c-3.990894 4.001127-9.230222 5.996574-14.46955 5.996574s-10.478655-1.995447-14.46955-5.996574l-102.023628-102.013395c-7.992021-7.992021-7.992021-20.947078 0-28.939099s20.947078-8.002254 28.939099 0l67.087954 67.077721 0-358.699522c0-11.2973 9.15859-20.466124 20.466124-20.466124 11.307533 0 20.466124 9.168824 20.466124 20.466124l0 358.699522 67.087954-67.077721c7.992021-8.002254 20.947078-7.992021 28.939099 0S637.250632 812.718993 629.258611 820.711014z"
                        p-id="1339"
                    />
                </svg>
            </div>
        </div>
        <div
            class="app-error"
            v-if="app.path == undefined"
        >未发现代码段存放目录</div>
        <div
            class="app-content"
            v-if="app.path != undefined"
        >
            <div class="app-list">
                <div
                    class="app-file"
                    v-for="file in app.files"
                    @click="onFileClicked(file)"
                >
                    <div class="app-file-name">
                        <div style="margin-right: auto;">{{ file.name }}</div>
                        <!-- ok -->
                        <svg
                            @click="saveFile"
                            v-if="file.isEdit"
                            t="1589287735201"
                            class="icon"
                            viewBox="0 0 1024 1024"
                            version="1.1"
                            xmlns="http://www.w3.org/2000/svg"
                            p-id="5668"
                            width="16"
                            height="16"
                        >
                            <path
                                d="M860.048 375.018 522.717 712.35l-63.366 63.365c-8.387 8.387-20.035 13.045-31.684 13.045-11.647 0-23.296-4.658-31.683-13.045l-63.366-63.365L163.953 543.684c-8.387-8.387-13.047-20.035-13.047-31.683s4.66-23.296 13.047-31.683l63.365-63.366c8.387-8.387 20.035-13.046 31.684-13.046s23.296 4.659 31.683 13.046l136.982 137.447 305.648-306.113c8.387-8.387 20.035-13.046 31.683-13.046 11.648 0 23.297 4.659 31.684 13.046l63.366 63.366c8.387 8.387 13.046 20.035 13.046 31.683C873.094 354.983 868.435 366.631 860.048 375.018z"
                                p-id="5669"
                            />
                        </svg>
                        <!-- left -->
                        <svg
                            v-if="file.select == false"
                            t="1589199064605"
                            class="icon"
                            viewBox="0 0 1024 1024"
                            version="1.1"
                            xmlns="http://www.w3.org/2000/svg"
                            p-id="2141"
                            width="16"
                            height="16"
                        >
                            <path
                                d="M409.6 512l196.266667-192c12.8-12.8 12.8-38.4 0-51.2-12.8-12.8-38.4-12.8-51.2 0l-226.133334 217.6c-12.8 12.8-12.8 38.4 0 51.2l226.133334 217.6c12.8 12.8 38.4 12.8 51.2 0 12.8-12.8 12.8-38.4 0-51.2L409.6 512z"
                                p-id="2142"
                            />
                        </svg>
                        <!-- rigth -->
                        <svg
                            v-if="file.select == true"
                            t="1589199213337"
                            class="icon"
                            viewBox="0 0 1024 1024"
                            version="1.1"
                            xmlns="http://www.w3.org/2000/svg"
                            p-id="2989"
                            width="16"
                            height="16"
                        >
                            <path
                                d="M512 626.752l265.344-265.408c30.208-30.144 75.456 15.104 45.312 45.312l-288 288a30.976 30.976 0 0 1-24.064 9.856c-5.184 0.512-13.696-2.368-21.248-9.856l-288-288c-30.144-30.208 15.104-75.456 45.312-45.312L512 626.752z"
                                p-id="2990"
                            />
                        </svg>
                    </div>
                    <div
                        class="app-snippet-addnew"
                        v-if="file.select == true"
                        @click.stop="addNew"
                    >
                        <!-- add -->
                        <svg
                            style="margin-right:10px;"
                            t="1589355817004"
                            class="icon"
                            viewBox="0 0 1024 1024"
                            version="1.1"
                            xmlns="http://www.w3.org/2000/svg"
                            p-id="2131"
                            data-spm-anchor-id="a313x.7781069.0.i4"
                            width="16"
                            height="16"
                        >
                            <path
                                d="M575.667042 895.509581 575.667042 575.705927 895.469672 575.705927 895.469672 447.784466 575.667042 447.784466 575.667042 127.981836 447.74558 127.981836 447.74558 447.784466 127.941927 447.784466 127.941927 575.705927 447.74558 575.705927 447.74558 895.509581Z"
                                p-id="2132"
                                data-spm-anchor-id="a313x.7781069.0.i0"
                                class
                                fill="#000000"
                            />
                        </svg>
                        add new...
                    </div>
                    <!-- <transition-group name="list" tag="div"> -->
                    <div
                        v-for="(snippet, key) in file.snippets"
                        class="app-snippet"
                        v-if="file.select == true"
                        v-bind:key="key"
                        @click.stop="onSnippetClicked(snippet)"
                    >
                        <div style="margin-right: auto;">{{ snippet.prefix }}</div>
                        <svg
                            @click.stop="deleteSnippet(snippet)"
                            t="1589199630246"
                            class="icon"
                            viewBox="0 0 1024 1024"
                            version="1.1"
                            xmlns="http://www.w3.org/2000/svg"
                            p-id="4713"
                            width="16"
                            height="16"
                        >
                            <path
                                d="M684.8 236.8l100.266667 102.4c2.133333 2.133333 4.266667 6.4 4.266666 10.666667s-2.133333 6.4-4.266666 10.666666l-151.466667 151.466667 151.466667 151.466667c2.133333 2.133333 4.266667 6.4 4.266666 10.666666s-2.133333 8.533333-4.266666 10.666667l-100.266667 100.266667c-2.133333 2.133333-6.4 4.266667-10.666667 4.266666s-6.4-2.133333-10.666666-4.266666l-151.466667-151.466667-151.466667 151.466667c-2.133333 2.133333-6.4 4.266667-10.666666 4.266666s-8.533333-2.133333-10.666667-4.266666l-100.266667-100.266667c-2.133333-2.133333-4.266667-6.4-4.266666-10.666667s2.133333-6.4 4.266666-10.666666l151.466667-151.466667-151.466667-151.466667c-2.133333-2.133333-4.266667-6.4-4.266666-10.666666s2.133333-8.533333 4.266666-10.666667l100.266667-100.266667c2.133333-2.133333 6.4-4.266667 10.666667-4.266666s6.4 2.133333 10.666666 4.266666l151.466667 151.466667 151.466667-151.466667c2.133333-2.133333 6.4-4.266667 10.666666-4.266666 4.266667-2.133333 8.533333 0 10.666667 2.133333z"
                                p-id="4714"
                            />
                        </svg>
                    </div>
                    <!-- </transition-group> -->
                </div>
            </div>
            <div
                class="app-editor"
                v-if="app.snippet != undefined"
            >
                <div class="app-key">
                    <input
                        @keydown="onEdit"
                        class="app-key-input"
                        contenteditable="true"
                        spellcheck="false"
                        v-model="app.snippet.prefix"
                    />
                </div>
                <div class="app-tools">
                    <button
                        @click="onInsert"
                        v-for="value in inserts"
                        :value="'$' + value"
                    >{{ "$" + value }}</button>
                </div>
                <div class="app-editor-content max">
                    <textarea
                        tabindex="1"
                        ref="txtarea"
                        v-model="app.snippet.body"
                        contenteditable="true"
                        spellcheck="false"
                        @keydown.stop="onEdit"
                    ></textarea>
                </div>
            </div>
        </div>
        <div
            class="app-msg"
            v-if="app.msgs.length >0"
        >
            <div
                class="app-msg-item"
                v-for="item in app.msgs"
            >{{item}}</div>
        </div>
    </div>
</template>

<script>
{
    name: "app",
    data:function(){return{
        app:app,
        inserts:[0,1,2,3,4,5,6,7,8,9,"{:}","{||}"]
    }},
    methods: {
        onFileClicked:function(file){			
            app.select(file);
        },
        onSnippetClicked:function(snp){
            app.snippet = snp
        },
        onInsert:function(e){
            var value = e.target.value
            var el = this.$refs.txtarea

            var start = el.selectionStart
            var end = el.selectionEnd
            el.value = el.value.substring(0, start)
                        + value.substring(0,3) +el.value.substring(start,end)+ value.substring(3)
                        + el.value.substring(end)
            el.selectionStart = start + 2
            el.selectionEnd = start + 2
            app.snippet.body = el.value
            el.focus()
		},
		onEdit:function(e){			            
            var el = this.$refs.txtarea
                if (e.keyCode == 9) {
                    e.preventDefault()
                    var indent = '    '
                    var start = el.selectionStart
                    var end = el.selectionEnd
                    var selected = window.getSelection().toString()
                    selected = indent + selected.replace(/\n/g, '\n' + indent)
                    el.value = el.value.substring(0, start) + selected
                            + el.value.substring(end)
                    el.setSelectionRange(start + indent.length, start
                            + selected.length)                    
                            app.snippet.body = el.value
                }

            app.selected.isEdit = true;		            
		},
		saveFile:function(){
			app.save();
		},
		addNew:function(){
			var newSnpt =  {prefix:"NewSnippet",body:'',description:''}
			app.selected.snippets.unshift(newSnpt);
            app.snippet = newSnpt;
            app.selected.isEdit = true;						
        },
        deleteSnippet:function(snpt){
            snpt.delete = true;
            app.deleteSnippet(snpt);
            app.selected.isEdit = true;						
        }
    },
}
</script>
<style>
.list-enter-active {
    transition: all 0.5s;
}
.list-enter {
    opacity: 0;
    transform: translateX(30px);
}
.max {
    width: 100%;
    height: 100%;
}
#app {
    width: 100%;
    height: 100%;
}
.app {
    width: 100%;
    height: 100%;
    display: flex;
    flex-direction: column;
}
.app-title {
    padding-left: 10px;
    width: calc(100% - 10px);
    border-bottom: 0.5px solid gray;
    display: flex;
    flex-direction: column;
}
.app-title-name {
    width: 100%;
    height: auto;
    display: flex;
    align-items: center;
}
.app-title-name h2 {
    width: 100%;
}
.app-title-name span {
    font-family: 微软雅黑;
    font-size: 3px;
}
.app-content {
    width: 100%;
    height: 100%;
    display: flex;
    flex-direction: row;
}
.app-list {
    min-width: 300px;
    height: 100%;
    border-right: 0.5px solid gray;
    overflow-y: auto;
}
.app-list::-webkit-scrollbar {
    display: none;
}
.app-editor {
    width: 100%;
    height: 100%;
    display: flex;
    flex-direction: column;
}
.app-file {
    min-height: 40px;
}
.app-file-name {
    min-height: 40px;
    padding-left: 10px;
    display: flex;
    align-items: center;
    cursor: pointer;
    padding-right: 10px;
    font-family: 微软雅黑;
    font-weight: bolder;
    font-size: 16px;
}
.app-file-name:hover {
    background: lightgray;
}
.app-snippet {
    padding-left: 40px;
    min-height: 30px;
    padding-right: 10px;
    display: flex;
    align-items: center;
    font-family: 微软雅黑;
    font-weight: bolder;
    font-size: 14px;
}
.app-snippet:hover {
    background: lightgray;
}
.app-snippet-addnew {
    padding-left: 14px;
    min-height: 30px;
    padding-right: 10px;
    display: flex;
    align-items: center;
    font-family: 微软雅黑;
    font-weight: bolder;
    font-size: 14px;
}
.app-snippet-addnew:hover {
    background: lightgray;
}
.app-tools {
    display: flex;
}
.app-editor {
    padding: 10px;
    width: calc(100% - 20px);
    height: calc(100% - 20px);
}
.app-key {
    margin: 10px 0;
    height: 20px;
    display: flex;
    align-items: center;
}
.app-key input {
    font-family: 微软雅黑;
    font-size: 16px;
    font-weight: bolder;
    outline: none;
    border: none;
}
.app-key-input {
    width: 100%;
    height: 20px;
}
.app-editor-content {
    display: flex;
    flex-direction: row;
    justify-items: stretch;
    align-items: stretch;
}
svg:hover {
    background: lightcoral;
}
button {
    background: white;
    outline: none;
    border: 1px solid lightblue;
    font-size: 16px;
    margin: 2px;
    width: auto;
    height: auto;
    padding: 5px;
}
textarea {
    width: 100%;
    height: 100%;
    font-family: 微软雅黑;
    font-size: 16px;
    font-weight: bolder;
    border: none;
    outline: none;
}
.app-msg {
    position: fixed;
    top: 10px;
    left: calc(50% - 250px);
    width: 500px;
    display: flex;
    flex-direction: column;
    align-items: center;
}
.app-msg-item {
    background: white;
    border: lightgray;
    padding: 10px 30px;
    box-shadow: 0 0 3px black;
    margin: 3px;
}
</style>
