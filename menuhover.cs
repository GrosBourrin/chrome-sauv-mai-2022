:root {
	--uc-menubar-spacer: 11px
}

:root[sizemode="maximized"] {
	--uc-menubar-spacer: 1px
}

#nav-bar-customization-target,
#PanelUI-button,
#nav-bar-overflow-button,
#TabsToolbar>.toolbar-items {
	position: relative;
	z-index: 5;
}

#toolbar-menubar>spacer {
	flex-grow: 1
}

#toolbar-menubar>spacer,
#toolbar-menubar>.titlebar-buttonbox-container {
	order: 1000
}

#TabsToolbar>.titlebar-spacer {
	display: -moz-box !important;
}

:where(#toolbar-menubar) {
	-moz-window-dragging: no-drag;
}

#toolbar-menubar:not([customizing]) {
	--uc-menubar-height: 34px;
	position: fixed;
	display: flex;
	width: 100vw;
	height: var(--uc-menubar-height);
	/* --uc-menubar-extra-margin is defined in toolbars_below_content.css */
	margin-top: calc(var(--uc-menubar-spacer) - var(--uc-menubar-height) + var(--uc-menubar-extra-margin, 0px));
	transition: margin-top 150ms linear !important;
	z-index: 4;
}

#toolbar-menubar:hover {
	background-color: var(--toolbar-bgcolor) !important;
	margin-top: var(--uc-menubar-extra-margin, 0px) !important;
	z-index: 6
}

#main-menubar>menu {
	padding-bottom: 4px
}

/* This exists only for compatibility reasons with some other styles */
#navigator-toolbox {
	--uc-hide-window-control-space: 0
}
