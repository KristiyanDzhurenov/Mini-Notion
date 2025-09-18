<template>
    <header width="100%" height="60px" class="main-hdr">
        <div width="100%" height="100%" class="hdr-main-div">
            <div width="fit-content" height="100%" class="hdr-div">
                <button class="hdr-btn">MiniNotion</button>
            </div>
            <div width="fit-content" height="100%" class="hdr-div">123</div>
            <div width="fit-content" height="100%" class="hdr-div">123</div>
        </div>
    </header>
</template>

<style scoped>
.main-hdr {
    width: 100%;
    height: 60px;
    
}

.hdr-div {
    width: fit-content;
    height: 100%;
}

.hdr-main-div {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: space-between;
}

.hdr-btn {
    color: black;
    background-color: white;
}
</style>